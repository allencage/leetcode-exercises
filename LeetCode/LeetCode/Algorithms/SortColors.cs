using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{

	/*
		Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, 
		with the colors in the order red, white and blue.
		Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
		Note:
		You are not suppose to use the library's sort function for this problem.
	 */
	public static class SortColors
	{
		public static void Sort(int[] nums)
		{
			for (var i = 0; i < nums.Length; i++)
				for (var j = 0; j < nums.Length - 1; j++)
					if (nums[j] > nums[j + 1])
					{
						var a = nums[j + 1];
						nums[j + 1] = nums[j];
						nums[j] = a;
					}
		}
	}
}
