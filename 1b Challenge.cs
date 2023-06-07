/*
Jake Hathaway
Challenge 1b (DGM 1610)
6/2/2023
All code is original and typed by me
*/

//Objective 1: Enhance the "Temperature Adviser" program from the lab assignment. Modify the existing code to check for different temperature ranges and provide more specific advice based on the conditions. Customize the messages based on the temperature conditions to provide detailed weather advice. For example, if the temperature is below 10 degrees Celsius, suggest wearing warm clothing. I recommend carrying a light jacket if the temperature is between 10 and 20 degrees Celsius.

//Objective 2: Expand the "Exam Grader" program from the lab assignment. In addition to displaying the grade based on the exam score, prompt the user to enter their favorite subject. Use a switch statement to display a message related to their chosen topic. For example, if the issue is "Math," show a message encouraging them to keep practicing and exploring mathematical concepts. Customize the messages for different subjects and make it fun and encouraging.
using System;

class Program {
  public static void Main (string[] args) {
  try{
    //Declare variables, get user input.
    Console.WriteLine ("What is the current temperature (in celcius)?");
    //Condition check
    int userInput = Convert.ToInt32 (Console.ReadLine());

  
      //32 Degrees C and above
      if (userInput > 32)
        {
          Console.WriteLine("\nCAUTION: If it's over 32°C right now, seek shelter or shade as soon as possible. \nProlonged durration above 32°C outside can cause symptoms such as dehydration, fatigueness, heat stroke, headaches, nausea or vomiting, sunburns, and so on. Please stay in the shade and to stay hydrated until temperatures cool down more.\n");
        }
  
      //25-31 Degrees C
      else if (userInput <= 31 &&  userInput >= 25)
        {
          Console.WriteLine("\nCurrent Weather: Hot\nNothing better than out on a warm day! Since temperatures are above average, consider wearing clothes that are light and breathable such as short sleve shirts, tank tops, shorts, sandals/sneakers, as well as a hat and sunglasses on a bright day. \nConsider applying sunscreen if going out for a prolonged perior of time and to always stay hydrated.");
        }
  
      //18 to 24 Degrees C
      else if (userInput <= 24 &&  userInput >= 18)
        {
          Console.WriteLine("\nCurrent Weather: Warm\nCouldn't have asked for a better day! The perfect temperature range for whatever activities planned for your day. \nDress whatever makes you feel comfterable; whether it be a long-sleeve shirt and jeans, or a tanktop with shorts. Nothing can stand in your way on this perfect day! Remember as always to stay hydrated.");
        }
  
      //10 to 17
      else if (userInput <= 17 &&  userInput >= 10)
        {
          Console.WriteLine("\nCurrent Weather: Cool\nA bit on the cooler side today, but no fret. Consider wearing something that will cover both your arms and legs, such as long sleve shirts, and pants/jeans. \nYou could also consider a hoodie or a jacket if you need extra layers. If does start to rain, consider bringing an umbrella as well to keep you nice and dry. Remember as always to stay hydrated.");
        }
  
          //0 to 9
      else if (userInput <= 9 &&  userInput >= 0)
        {
          Console.WriteLine("\nCurrent Weather: Cold\nBhurrr is it cold outside. This means that your body too will start to get cold if you don't put on layers. Consider wearing pants as well as a insulated coat and boots if you plan to go outside. \nConsider also wearing other clothing accessories such as a beannie, gloves, scarves, and even wool sock if you need to add extra layers to keep you cold. While a cup of hot cocoa or coffee would sound like the best way to warm yourself up, always remember to stay hydrated.");
        }
      else if (userInput < 0)
        {
          Console.WriteLine("\nCAUTION: If it's below 0°C, seek shelter in a well insulated building or shelter. Prolonged exposure to the cold can include symptoms such as chills/shivers, loss of body heat, fatigue, drowsyness, Gangrene, frostbite, and even hypothermia which can lead to death if untreated. \nIf you do plan to go outside, wear as many dry, insulated layers on your body to prevent loss of body heat. Including a heavy winter coat, insulated pants, winter boots, gloves, beanies, scarves, and thermal clothing underneat to keep your body well insulated. Although it may be frigid outside, please don't forget to keep your body hydrated.");
        }
    }
    catch
    {
      Console.WriteLine("\nInvalid Response.");
    }
    //Part B: Grade checker
    //Use a try-catch condition if they type anything else other than a number.
      try
      {
        Console.WriteLine ("\nNow let's check your exam grade.\nPlease enter your exam score percentage:");
        int examResponse = Convert.ToInt32 (Console.ReadLine());
      
        //If the exam is over 100%
        if (examResponse > 100)
        {
          Console.WriteLine("\nNo way you got over 100% on the exam. Try again.");
        }
        //A
        else if (examResponse <= 100 && examResponse >= 94)
          {
            Console.WriteLine("\nFinal Score: A\nCongragulations!");
          }
        //A-
        else if (examResponse <= 93 && examResponse >= 90)
          {
            Console.WriteLine("\nFinal Score: A-");
          }
        //B+
        else if (examResponse <= 89 && examResponse >= 87)
          {
            Console.WriteLine("\nFinal Score: B+");
          }
        //B
        else if (examResponse <= 86 && examResponse >= 84)
          {
            Console.WriteLine("\nFinal Score: B");
          }
        //B-
        else if (examResponse <= 83 && examResponse >= 80)
          {
            Console.WriteLine("\nFinal Score: B-");
          }
        //C+
        else if (examResponse <= 79 && examResponse >= 77)
          {
            Console.WriteLine("\nFinal Score: C+");
          }
        //C
        else if (examResponse <= 76 && examResponse >= 74)
          {
            Console.WriteLine("\nFinal Score: C");
          }
        //C-
        else if (examResponse <= 73 && examResponse >= 70)
          {
            Console.WriteLine("\nFinal Score: C-");
          }
        //D+
        else if (examResponse <= 69 && examResponse >= 67)
          {
            Console.WriteLine("\nFinal Score: D+");
          }
        //D
        else if (examResponse <= 66 && examResponse >= 64)
          {
            Console.WriteLine("\nFinal Score: D");
          }
        //D-
        else if (examResponse <= 63 && examResponse >= 60)
          {
            Console.WriteLine("\nFinal Score: D-");
          }
        //F
        else if (examResponse <= 50 && examResponse >= 0)
          {
            Console.WriteLine("\nFinal Score: F");
          }
        //Invalid input checker
        else
          {
            Console.WriteLine("\nInvalid Input. Please try again.");
          }
        }
      //Catch if anything but a number is inputed.
      catch
      {
        Console.WriteLine("\nInvalid Input. Please Try again");
      }  
    

    //In addition to displaying the grade based on the exam score, prompt the user to enter their favorite subject.
    Console.WriteLine("\nTo conclude, what is your favorite subject to study about?");
    string courseResponse = Console.ReadLine();

    switch(courseResponse.ToLower())
    {
    case "math":
      Console.WriteLine("\nWhile math can be easy for some, math can be a tricky course for others. Some concepts and principles in math may seem daunting at times, but remember that it's a skill that can be developed with practice and effort. While some math concepts may seem pointless to some, there are so many important applications with math that are both useful and practical outside of the classroom. There are plenty of online sources as well as tutors both in-person and online that will help you if you are struggling with any mathematical concept. But most imporant of all, is to never give up!");
      break;
      
    case "english":
      Console.WriteLine("\nFirst and foremost, remember that writing is a craft that can be honed through consistent practice. Embrace the process and give yourself permission to make mistakes, as they are opportunities for growth. Read voraciously and expose yourself to a wide range of literature to expand your vocabulary and deepen your understanding of language. Writing is not only about mechanics but also about connecting with your audience. Cultivate empathy and consider the perspectives of your readers. Tailor your writing to engage and captivate them, making your ideas and thoughts resonate. Remember, clarity is key, so strive for concise and coherent writing that conveys your message effectively. But most imporant of all, is to never give up!");
      break;
      
    case "writing":
      Console.WriteLine("\nFirst and foremost, remember that writing is a craft that can be honed through consistent practice. Embrace the process and give yourself permission to make mistakes, as they are opportunities for growth. Read voraciously and expose yourself to a wide range of literature to expand your vocabulary and deepen your understanding of language. Writing is not only about mechanics but also about connecting with your audience. Cultivate empathy and consider the perspectives of your readers. Tailor your writing to engage and captivate them, making your ideas and thoughts resonate. Remember, clarity is key, so strive for concise and coherent writing that conveys your message effectively. But most imporant of all, is to never give up!");
      break;
      
    case "physics":
      Console.WriteLine("\nPhysics is a field that combines curiosity, critical thinking, and problem-solving skills. Embrace a growth mindset and approach each concept and problem as an opportunity to expand your understanding. Remember that physics is not about memorizing formulas but understanding the underlying principles and applying them to real-world scenarios. Develop a strong foundation in mathematics, as it forms the language of physics. Dedicate time to mastering mathematical concepts such as calculus, algebra, and trigonometry. This will enable you to express and manipulate physical relationships with confidence and precision. And lastly, know that you're not in this alone. Learn how to collaborate with others. Engage in discussions, solve problems together, and challenge each other's thinking. Explaining concepts to others can deepen your own understanding and foster a supportive learning community. But most imporant of all, is to never give up!");
        break;
      
    case "chemistry":
      Console.WriteLine("\nChemistry is a field that requires a solid foundation and an inquisitive mind. Embrace the fundamental principles of chemistry and invest time in understanding the underlying concepts. Focus on topics such as atomic structure, chemical bonding, and stoichiometry, as they form the building blocks for more advanced topics. Engage actively with the subject matter by conducting experiments and observing chemical phenomena firsthand. Embrace the opportunity to work in a laboratory setting and gain practical experience. Seek out additional resources like textbooks, online tutorials, and interactive simulations to further reinforce your understanding. Collaborate with peers and educators who share your passion for chemistry. Engage in discussions, ask questions, and participate in group activities. By working together, you can enhance your comprehension and develop new insights. But most imporant of all, is to never give up!");
      break;
      
    case "history":
      Console.WriteLine("\nHistory is not merely about memorizing dates and events; it is about understanding the stories and perspectives that have shaped our world. Embrace the principles of critical thinking and analysis as you explore historical narratives. Seek out multiple sources and viewpoints to develop a well-rounded understanding of different historical periods and events. Immerse yourself in the richness of historical literature, biographies, and primary sources. This will allow you to delve deep into the context, motivations, and complexities of historical events. Look for connections between past and present, as history often provides valuable insights into contemporary issues and societal developments. Finally, embrace the stories of the past with passion and empathy. Remember that history is not a static subject but a dynamic tapestry of human experiences. Explore the diverse range of historical periods, cultures, and civilizations, and let their stories inspire you. But most imporant of all, is to never give up!");
      break;
      
    case "art":
      Console.WriteLine("\nArt is a beautiful realm that allows you to express your unique voice and vision. Embrace the principles of practice and exploration, knowing that each stroke of the brush or pencil brings you closer to mastery. Set aside regular time for creating art, and be open to experimenting with different mediums, techniques, and styles. Observe the world around you with a keen eye, and let it inspire your creativity. Pay attention to shapes, colors, textures, and light. Seek out inspiration from the works of established artists, but also trust in your own intuition and personal experiences. Remember that art is a reflection of your inner world, so embrace your individuality and let it shine through your creations. Seek constructive feedback from fellow artists, mentors, or art communities. Embrace critique as an opportunity for growth, and don't be afraid to step out of your comfort zone. Engage in discussions, attend workshops, and collaborate with other artists to expand your horizons and gain fresh perspectives. But most imporant of all, is to never give up!");
      break;
      
    default:
      Console.WriteLine("\nThat doesn't seem to be a course that I recognize. But whatever course or subject you're taking, just know that studying and practicing are two of the most important principles a person can learn no matter what subject you're taking. But just remember that the most improtatnt principle of all, is to never give up!");
      break;  
    }
  }
}