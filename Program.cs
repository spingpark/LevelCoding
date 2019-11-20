using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    class program
    {
        static void Main(string[] args)
        {
            //string[] s = new string[] { "abce", "abcd", "cdx" };
            //Solution frm = new Solution();
            //frm.solution(s, 2);

            //int[] lost = new int[] { 1, 3, 5 ,7};
            //int[] reserve = new int[] { 1,4};
            //Solution2 frm = new Solution2();
            //frm.solution(5, lost,reserve);

            int[] lost = new int[] { 1, 5, 2, 6, 3, 7, 4 };
            int[,] reserve = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
            Solution3 frm = new Solution3();
            frm.solution(lost, reserve);
        }
    }
    public class Solution3
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            List<int> list = array.ToList();

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                List<int> templist = list.GetRange(commands[i, 0] - 1, commands[i, 1] - commands[i, 0] + 1);
                templist = templist.OrderBy(d => d).ToList();
                answer[i] = templist[commands[i, 2] - 1];

            }

            return answer;
        }

       
    }
    public class Solution2
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = n - lost.Length;
            int re = reserve.Length;
            List<int> reservelist = new List<int>();
            reservelist = reserve.ToList();

            

            foreach(int l in lost)
            {

                for (int i = 0; i < reservelist.Count; i++)
                {
                    if (l.Equals(reservelist[i]) || l.Equals(reservelist[i] - 1) || l.Equals(reservelist[i] + 1))
                    {
                        reservelist.RemoveAt(i);
                        answer += 1;
                    }
                }
            }

            if (answer > n)
                answer = n;


            return answer;
        }

        
    }


    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            
            string[] answer = new string[] { };
            strings = strings.OrderBy(d => d).ToArray();
            answer = strings.OrderBy(d=> d[n]).ToArray();

            

            
            return answer;
        }
    }
}
