using System;

class Clock{

  // static int findDegree(int hour,int minute){
	//   if(hour < 0 || hour > 12 || minute > 60){
	// 	  Console.WriteLine("Not a correct time");
	//   }
	//   if(hour == 12){
	// 	  hour = 0;
	//   }
	//   if (minute == 60) {
	// 	  minute = 0; 
	//   } 
	//     int hour_angle = (int)(0.5 * (hour * 60 +minute )); 
  //       int minute_angle = (int)(6 * minute); 
		
	// 	int angle = Math.Abs(hour_angle - minute_angle); 
	// 	angle = Math.Min(360 - angle, angle); 
  
  //       return angle; 
            
  // }
  
  static void Main(){
 // Console.WriteLine("Enter a time ");
 // 10:20

	Console.WriteLine("Enter a time for hour hand");
    string time = Console.ReadLine();
		string[] strTime = time.Split(":");
		Console.WriteLine(strTime[0]);

    
	//findDegree(hour,minute);

 }
}























