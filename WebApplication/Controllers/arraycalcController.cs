using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class arraycalcController : ApiController
    {
        [HttpGet]
        public int[] reverse([FromUri] int[] productIds)
        {

            return reversearray(productIds);
        }

       
 
         [HttpGet]
        public int[] deletepart([FromUri] int[] productIds,int position)
        {

            return removeat(productIds,position);
        }

        //Helper Function
        public int[] reversearray(int[] arr)
        {
            int[] reverse = new int[5];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reverse[(arr.Length - 1) - i] = arr[i];
            }
            return reverse;
        }

        public int[] removeat(int[] arr, int position)
        {
            int[] removingarray = new int[4];
            int j = 0;
            for (int i =0; i <= arr.Length - 1; i++)
            {
                if (arr[i] != position)
                {
                    removingarray[j++] = arr[i];
                }
               
                
            }
            return removingarray;
        }


    }
}
