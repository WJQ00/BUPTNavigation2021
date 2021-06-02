using System;
using System.Collections;
using System.Collections.Generic;
using StatsTypes;
using Stats;

namespace PATHFinding
{
    //path between two building(or navigation point)
    public struct Path
    {
        public bool[] navigationPointsIndex;//��¼�м�ڵ��Ƿ���ڵĲ�������
        public int num;//�м�ڵ�ĸ���
        public double []time;//0-����ʱ�䣻1-���г�ʱ��
        public int distance;//����    
    }
    public class PathFinding
    {
        private static PathStats pathStats = new PathStats();
        private static Path[,] InitialMatrix = new Path[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];
        //private static Path[,] BicycleMatrix = new Path[BaseStats.navigationPointCount + 1, BaseStats.navigationPointCount + 1];
        private const int WalkSpeed = 70;
        private const int RideSpeed = 300;
        static PathFinding()
        {
            InitInitialMatrix();
            
        }
        /*��ʼ����ͼ�ڽӾ��������*/
        private static void InitInitialMatrix()
        {
            for (int i = 1; i < BaseStats.navigationPointCount + 1; i++)
            {
                for (int j = 1; j < BaseStats.navigationPointCount + 1; j++)
                {
                    /*��ʼ���������м�ڵ����*/
                    InitialMatrix[i, j] = new Path();
                    InitialMatrix[i, j].distance = pathStats.paths[i, j].length;
                    InitialMatrix[i, j].num = 0;
                    
                    /*��ʼ�м�ڵ�Ĳ������󣬲�������յ����*/
                    InitialMatrix[i, j].navigationPointsIndex = new bool[BaseStats.navigationPointCount + 1];
                    InitialMatrix[i, j].navigationPointsIndex[i] = true;
                    InitialMatrix[i, j].navigationPointsIndex[j] = true;
                    
                    /*��ʼ����ʱ�������г�ʱ��*/
                    InitialMatrix[i, j].time = new double[2];
                    if (InitialMatrix[i, j].distance == -1)                   
                        InitialMatrix[i, j].time[0] = InitialMatrix[i, j].time[1] = -1;
                    else if(InitialMatrix[i, j].distance == 0)
                        InitialMatrix[i, j].time[0] = InitialMatrix[i, j].time[1] = 0;
                    else if (pathStats.paths[i, j].bicycle == true)
                    {
                        InitialMatrix[i, j].time[1] = pathStats.paths[i, j].length / (RideSpeed * pathStats.paths[i, j].crowded);
                        InitialMatrix[i, j].time[0]= pathStats.paths[i, j].length / (WalkSpeed * pathStats.paths[i, j].crowded);
                    }
                    else
                    {
                        InitialMatrix[i, j].time[1] = pathStats.paths[i, j].length / (WalkSpeed * pathStats.paths[i, j].crowded);
                        InitialMatrix[i, j].time[0] = pathStats.paths[i, j].length / (WalkSpeed * pathStats.paths[i, j].crowded);
                    }
                }//for j
            }//for i
        }//InitInitialMatrix()
        /*�������·�����ڽӾ���*/
        private static void UpdateMinDistanceMatrix(Path[,] Matrix)
        {
            for (int k = 1; k < BaseStats.navigationPointCount + 1; k++)
                for (int i = 1; i < BaseStats.navigationPointCount + 1; i++)
                    for (int j = 1; j < BaseStats.navigationPointCount + 1; j++)
                    {
                        if (Matrix[i, k].distance != -1 && Matrix[k, j].distance != -1)
                            if (Matrix[i, j].distance > (Matrix[i, k].distance + Matrix[k, j].distance) || Matrix[i, j].distance == -1)
                            {
                                Matrix[i, j].distance = Matrix[i, k].distance + Matrix[k, j].distance;
                                Matrix[i, j].num = Matrix[i, k].num + Matrix[k, j].num + 1;
                                for (int m = 1; m < BaseStats.navigationPointCount + 1; m++)
                                    Matrix[i, j].navigationPointsIndex[m] = Matrix[i, k].navigationPointsIndex[m] || Matrix[k, j].navigationPointsIndex[m];                               
                            }
                    }
        }
        /*�������ʱ����ڽӾ���*/
        private static void UpdateMinTimeMatrix(Path[,] Matrix, int type)
        {
            for (int k = 1; k < BaseStats.navigationPointCount + 1; k++)
                for (int i = 1; i < BaseStats.navigationPointCount + 1; i++)
                    for (int j = 1; j < BaseStats.navigationPointCount + 1; j++)
                    {
                        if (Matrix[i, k].time[type] != -1 && Matrix[k, j].time[type] != -1)
                            if (Matrix[i, j].time[type] > (Matrix[i, k].time[type] + Matrix[k, j].time[type]) || Matrix[i, j].time[type] == -1)
                            {
                                Matrix[i, j].time[type] = Matrix[i, k].time[type] + Matrix[k, j].time[type];

                                for (int m = 1; m < BaseStats.navigationPointCount + 1; m++)
                                    Matrix[i, j].navigationPointsIndex[m] = Matrix[i, k].navigationPointsIndex[m] || Matrix[k, j].navigationPointsIndex[m];
                            }
                    }
        }
        
        /*  ��������㡢�յ㡢������ݵ��ڽӾ���·��\ʱ��Ĳ���ѡ���·\���г�������
            ���ڽӾ����д�ŵ� ����յ�� �м�ڵ�Ĳ�������ת��Ϊһ��·������*/
        private static int[] SortPoint(int startIndex, int endIndex, Path[,] Matrix, bool time,int type)
        {          
            /*����䳤·������*/
            List<int>pointsList = new List<int>();

            for (int n = 1; n < BaseStats.navigationPointCount + 1; n++)           
                if (Matrix[startIndex, endIndex].navigationPointsIndex[n] == true )
                    pointsList.Add(n);

            /*��Ϊ�����·�������ʱ��ʱ�����ߵ�·��Ȩֵ����һ�������Ը���time���ֿ�*/
            Comparison<int> minlen = delegate (int a, int b)
            {
                if (Matrix[startIndex, a].distance < Matrix[startIndex, b].distance)
                    return -1;
                else if (Matrix[startIndex, a].distance == Matrix[startIndex, b].distance)
                    return 0;
                else
                    return 1;
            };
            Comparison<int> mintime = delegate (int a, int b)
            {
                if (Matrix[startIndex, a].time[type] < Matrix[startIndex, b].time[type])
                    return -1;
                else if (Matrix[startIndex, a].time[type] == Matrix[startIndex, b].time[type])
                    return 0;
                else
                    return 1;
            };

            if (time == false)
                pointsList.Sort(minlen);
            else
                pointsList.Sort(mintime);
            
            int[] points = pointsList.ToArray();
            return points;
        }//����¼ÿ���ڵ��Ƿ���ڵĲ�������ת��Ϊ����
        
        
        private static int[] EssentialPoint(int startIndex, int endIndex, Path[,] Matrix,bool time, int type, params int[] midIndex)
        {
            List<int> Receivealist = new List<int>();
            List<int> Ordered_Midpoints = new List<int>();

            foreach (int item in midIndex)
            {
                Receivealist.Add(item);               
            }
                       
            Comparison<int> Minlen = delegate (int a, int b)
            {
                if (Matrix[startIndex, a].distance < Matrix[startIndex, b].distance)
                    return -1;
                else if (Matrix[startIndex, a].distance == Matrix[startIndex, b].distance)
                    return 0;
                else
                    return 1;
            };
            Comparison<int> Mintime = delegate (int a, int b)
            {
                if (Matrix[startIndex, a].time[type] < Matrix[startIndex, b].time[type])
                    return -1;
                else if (Matrix[startIndex, a].time[type] == Matrix[startIndex, b].time[type])
                    return 0;
                else
                    return 1;
            };
            
            if (time == false)
            {
                Receivealist.Sort(Minlen);
                int num = Receivealist.Count;
            
                for(int i = 0;i < num; i++)
                {
                    Ordered_Midpoints.Add(Receivealist[0]);
                    Comparison<int> minlen = delegate (int a, int b)
                    {
                        if (Matrix[Receivealist[0], a].distance < Matrix[Receivealist[0], b].distance)
                            return -1;
                        else if (Matrix[Receivealist[0], a].distance == Matrix[Receivealist[0], b].distance)
                            return 0;
                        else
                            return 1;
                    };
                    Receivealist.Sort(minlen);
                    Receivealist.RemoveAt(0);
                }
            }
            else
            {
                Receivealist.Sort(Mintime);
                int num = Receivealist.Count;

                for (int i = 0; i < num; i++)
                {
                    Ordered_Midpoints.Add(Receivealist[0]);
                    Comparison<int> mintime = delegate (int a, int b)
                    {
                        if (Matrix[Receivealist[0], a].time[type] < Matrix[Receivealist[0], b].time[type])
                            return -1;
                        else if (Matrix[Receivealist[0], a].time[type] == Matrix[Receivealist[0], b].time[type])
                            return 0;
                        else
                            return 1;
                    };
                    Receivealist.Sort(mintime);
                    Receivealist.RemoveAt(0);
                }
            }
            
            Ordered_Midpoints.Insert(0, startIndex);
            Ordered_Midpoints.Add(endIndex);
           
            int inter = Ordered_Midpoints.Count - 1;
            for(int i = inter - 1;i >= 0; i--)
            {
                int[] temp = SortPoint(Ordered_Midpoints[i], Ordered_Midpoints[i + 1], InitialMatrix, time, type);
                List<int> interpoints = new List<int>(temp);
                
                interpoints.RemoveAt(interpoints.Count - 1);
                interpoints.RemoveAt(0);

                Ordered_Midpoints.InsertRange(i + 1, interpoints);
            }
            int[] way = Ordered_Midpoints.ToArray();

            return way;
        }

        /*Algo flag documentation
             Algo type      Bicycle      midpoint
        0:  mindistance       no           no
        1:  mindistance       no           yes
        2:  mindistance       yes          no
        3:  mindistance       yes          yes
        4:  mintime           no           no
        5:  mintime           no           yes
        6:  mintime           yes          no
        7:  mintime           yes          yes
         */
        public static int[] GetPath(int startIndex, int endIndex, int flag, params int[] midIndex)
        {
            switch (flag)
            {
                case 0:
                    UpdateMinDistanceMatrix(InitialMatrix);
                    return SortPoint(startIndex, endIndex, InitialMatrix, false, 0);
                     
                case 1:
                    UpdateMinDistanceMatrix(InitialMatrix);
                    return EssentialPoint(startIndex, endIndex, InitialMatrix, false, 0, midIndex);


                case 2:
                    UpdateMinDistanceMatrix(InitialMatrix);
                    return SortPoint(startIndex, endIndex, InitialMatrix, false, 1);
                    
                case 3:
                    UpdateMinDistanceMatrix(InitialMatrix);
                    return EssentialPoint(startIndex, endIndex, InitialMatrix, false, 1, midIndex);

                case 4:
                    UpdateMinTimeMatrix(InitialMatrix, 0);
                    return SortPoint(startIndex, endIndex, InitialMatrix, true, 0);
                     
                case 5:
                    UpdateMinTimeMatrix(InitialMatrix, 0);
                    return EssentialPoint(startIndex, endIndex, InitialMatrix, true, 0, midIndex);

                case 6:
                    UpdateMinTimeMatrix(InitialMatrix, 1);
                    return SortPoint(startIndex, endIndex, InitialMatrix, true, 1);
                    
                case 7:
                    UpdateMinTimeMatrix(InitialMatrix, 1);
                    return EssentialPoint(startIndex, endIndex, InitialMatrix, true, 1, midIndex);

                default:
                    return null;
            }
            //return new int[] { startIndex, 3, 4, endIndex };
        }
    }
}

