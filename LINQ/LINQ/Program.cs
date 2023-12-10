using LINQ;

int[] nums = { 20, 15, 31, 34, 35, 40, 50, 90, 99, 100 };
var gs = nums
 .ToLookup(k => k, k => nums.Where(n => n < k));

var g = nums;

LinqEntry.entryPoint();