using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
   class Program
   {
      static void Main(string[] args)
      {
         Solution x = Solution.getInstance();


         x.Shuffle(1);
      }
      
      
   }
   public class ListNode
   {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
         this.val = val;
         this.next = next;
      }
   }
   public class Solution
   {
      private static Solution instance;
      public static Solution getInstance()
      {
         if(instance == null) instance = new Solution();

         return instance;
      }

      public IList<IList<int>> ThreeSum(int[] nums)
      {
         var list = new List<int>();
         var retlist = new List<IList<int>>();
         if (nums.Length <= 2)
         {
            
            retlist.Add(list);
            return retlist;
         }

         Array.Sort(nums);
         var set = nums.ToHashSet();
         nums = set.ToArray();
         

         for (int i = 0; i < nums.Length; i++)
         {
            int first = 0;
            int last = nums.Length - 1;
            if (nums[i] == nums[first])
            {

            }
         }

         return retlist;
      }

      public void Shuffle(int num)
      {
         int[] deck = new int[52];
         
         for (int i = 0; i < deck.Length; i++)
         {
            deck[i] = i+1;
         }
         while (true)
         {
            var split1 = new int[26];
            var split2 = new int[26];

            for (int i = 0; i < 26; i++)
            {
               split1[i] = deck[i];
            }
            int j = 0;
            for (int i = 26; i < deck.Length; i++)
            {
               
               split2[j++] = deck[i];
            }
            j = 0;
            for (int i = 0; i < 26; i++)
            {
               deck[j++] = split2[i];
               deck[j++] = split1[i];
            }

            foreach(var c in deck)
            {
               Console.Write(c);
               Console.Write(',');
            }
            Console.WriteLine();
            Console.ReadLine();
         }
      }
      public int listToInt(ListNode l1)
      {
         int sum = 0;
         int i = 0;
         sum += (int)Math.Pow(l1.val, i++);
         while (l1.next != null)
         {
            l1 = l1.next;
            sum += (int)Math.Pow(l1.val, i++);
            l1 = l1.next;
         }
         return sum;
      }

      public ListNode intToList(int x)
      {
         ListNode l3 = new ListNode(x % 10, null);
         x /= 10;

         while (x >= 0)
         {
            l3 = l3.next;
            l3 = new ListNode(x % 10, null);
            x /= 10;
         }

         return l3;
      }

      public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
      {
         int x = listToInt(l1);
         int y = listToInt(l2);
         int sum = x + y;
         ListNode l3 = intToList(sum);
         return l3;
      }

      public bool IsMatch(string s, string p)
      {
         bool match = false;
         int i, j;
         char[] temp = s.ToCharArray();
         i = p.Length - 1;
         j = s.Length - 1;
         char x, y;
         x = y = ',';

         while (i >= 0)
         {
            if (j < 0)
            {
               return match;
            }
            if (p[i] == '*')
            {
               i--;
               y = p[i];
               if (j >= 0)
               {
                  x = s[j];
               }


               //if (x == y)
               //{
               //   temp[j] = y;
               //   j--;
               //   while (j >= 0 &&x == temp[j])
               //   {
               //      temp[j] = y;
               //      j--;
               //   }
               //}
               //else if (y == '.')
               //{
               //   temp[j] = x;
               //   j--;
               //   while (j >= 0 &&x == temp[j] )
               //   {
               //      temp[j] = x;
               //      j--;
               //   }
               //}
            }
            else
            {
               if (j >= 0)
               {
                  x = p[i];
                  temp[j] = x;
                  j--;
               }
            }

            i--;
         }
         string z = new string(temp);
         Console.WriteLine(z);
         if (z == s && j < 0)
         {
            match = true;
         }

         return match;
      }

   }
}
