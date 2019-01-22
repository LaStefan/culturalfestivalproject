using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DevelopPro
{
    public static class Extensions
    {
        public static string UpperFolder(this string pFolderName, Int32 pLevel)
        {
            List<string> TheList = new List<string>();

            while (!string.IsNullOrEmpty(pFolderName))
            {
                var temp = Directory.GetParent(pFolderName);
                if (temp == null)
                {
                    break;
                }

                pFolderName = Directory.GetParent(pFolderName).FullName;
                TheList.Add(pFolderName);

            }

            if (TheList.Count > 0 && pLevel > 0)
            {
                if (pLevel - 1 <= TheList.Count - 1)
                {
                    return TheList[pLevel - 1];
                }
                else
                {
                    return pFolderName;
                }
            }
            else
            {
                return pFolderName;
            }
        }
        public static string SolutionFolder(this string pSender)
        {
            return pSender.UpperFolder(4);
        }
    }
}
