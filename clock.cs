using System;

class Clock{

  static int findDegree(int hour,int minute){
	  if(hour < 0 || hour > 12 || minute < 0 || minute>60){
		  Console.WriteLine("Not a correct time");
	  }
	  if(hour == 12)hour = 0;
	  
	  if (minute == 60) minute = 0; 
	   
	    int hour_angle = (int)(0.5 * (hour * 60 +minute )); 
			
      int minute_angle = (int)(6 * minute); 
			
		
			int angle = Math.Abs(hour_angle - minute_angle); 
			angle = Math.Min(360 - angle, angle); 
			
			return angle; 
            
  }
  
  static void Main(){
 // Console.WriteLine("Enter a time ");
 // 10:20

	Console.WriteLine("Enter a time [12:20]");
    string time = Console.ReadLine();
		string[] strTime = time.Split(":");
		int hour = int.Parse(strTime[0]);
		int minute = int.Parse(strTime[1]);
		
    int result = findDegree(hour,minute);
		Console.WriteLine(result +" degree");

 }
}























