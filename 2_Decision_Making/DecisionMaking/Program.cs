namespace DecisionMaking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//if statement
			CompareNumbers();
			Temperature();

			//TryParse
			TryparseMethod_1();
			TryparseMethod_2();

			//TryParse + if else
			TemperaturePlusTryParse();
			TemperaturePlusTryParse_Refactored();

			//Nested If Statements
			CheckUser();
			CheckUserFactorised();
			CheckNumber();

            //Switch Statement
            SafePlanet();

			SafePlanetWithIf();

            Console.Read();
		}

		public static void CompareNumbers()
		{
			//This method compares two numbers
			Console.WriteLine("Please enter a number");
			string firstInput = Console.ReadLine();
			Console.WriteLine("Please enter another number");
			string secondInput = Console.ReadLine();

			int firstNumber = int.Parse(firstInput);
			int secondNumber = int.Parse(secondInput);
			
			//if statement
			if(firstNumber > secondNumber) 
			{
				//execute if condition is true
				Console.WriteLine("{0} is greater than {1}", firstNumber, secondNumber);
			}
			//execute if the first condition is false and this condition is true
			else if(firstNumber < secondNumber)
			{
				Console.WriteLine("{0} is less than {1}", firstNumber, secondNumber);
			}
			//execute if none of the conditions above is true.
			else
			{
				Console.WriteLine("{0} is equal to {1}", firstNumber, secondNumber);
			}
		}

		public static void Temperature()
		{
			//This method gives information about the day's weather
			Console.WriteLine("Please enter a number (1 - 100)to represent the degree of temperature");
			string input = Console.ReadLine();

			int degreeOfTemprature = int.Parse(input);//conversion error not handled here, program can cratch if conversion is !successful

			if(degreeOfTemprature > 100 || degreeOfTemprature < 1)
			{
				Console.WriteLine("{0} is not the correct input. Enter a number from 1-100", degreeOfTemprature);
			}
			else if(degreeOfTemprature >= 50 || degreeOfTemprature == 100)
			{
				Console.WriteLine("Its a sunny day!\nGo out and have fun!");
			}
			else if (degreeOfTemprature < 50 && degreeOfTemprature > 19)
			{
				Console.WriteLine("Its a moderate weather!\nYou may want to sit back or step out");
			}
			else
			{
				Console.WriteLine("Its a cold day!\nYou may want to sit back and have a cup of coffee");
			}
		}
		//Using the TryParse() method 
		public static void TryparseMethod_1()
		{
			string firstString = "347";

			bool isSuccessful = int.TryParse(firstString, out int number);//returns a boolean

			if (isSuccessful)
			{
				Console.WriteLine("Conversion to an integer: {0} was successful!", number);
			}
			else
			{
				Console.WriteLine("Conversion failure");
			}
		}

		public static void TryparseMethod_2()
		{
			string secondString = "3456.78";
			float parsedFloat;

			bool isASuccess = float.TryParse(secondString, out parsedFloat);

			if(isASuccess)
			{
				Console.WriteLine("{0} was successfully parsed to a float!", parsedFloat);
			}
			else
			{
				Console.WriteLine("invalid type conversion!");
			}
		}

		//else if + TryParse
		public static void TemperaturePlusTryParse()
		{
			Console.WriteLine("Please enter a number (1 - 100) to represent the degree of temperature");
			string input_2 = Console.ReadLine();

			bool isSuccess = int.TryParse(input_2, out int temperatureDegree);

			if(!isSuccess)
			{
				Console.WriteLine("Wrong input! \"{0}\" cannot be converted to an integer.", input_2); 
				return;
			}
			
			if (temperatureDegree > 100 || temperatureDegree < 1)
			{
				Console.WriteLine("{0} is out of the stipulated range. Enter a number from 1-100", temperatureDegree);
			}
			else if (temperatureDegree >= 50 || temperatureDegree == 100)
			{
				Console.WriteLine("Its a sunny day!\nGo out and have fun!");
			}
			else if (temperatureDegree < 50 && temperatureDegree > 19)
			{
				Console.WriteLine("Its a moderate weather!\nYou may want to sit back or step out");
			}
			else
			{
				Console.WriteLine("Its a cold day!\nYou may want to sit back and have a cup of coffee");
			}
		}

		public static void TemperaturePlusTryParse_Refactored()
		{
			//constants naming convention is diff. Unlike other variables, it is acceptable to begin with uppercase letters.
			const int MinTemprature = 1; 
			const int MaxTemperature = 100;
			const int ColdTemprature = 20;
			const int HotTemprature = 50;
			
			Console.WriteLine("Please enter a number (1 - 100) to represent the degree of temperature");
			string input_2 = Console.ReadLine();

			if (!int.TryParse(input_2, out int temperatureDegree))
			{
				Console.WriteLine("Wrong input! \"{0}\" cannot be converted to an integer.", input_2);
				return;//Exit the program
			}

			if (temperatureDegree > MaxTemperature || temperatureDegree < MinTemprature)
			{
				Console.WriteLine("{0} is out of the stipulated range. Enter a number from 1-100", temperatureDegree);
			}
			else if (temperatureDegree >= HotTemprature || temperatureDegree == MaxTemperature)
			{
				Console.WriteLine("Its a sunny day!\nGo out and have fun!");
			}
			else if (temperatureDegree < HotTemprature && temperatureDegree > ColdTemprature)
			{
				Console.WriteLine("Its a moderate weather!\nYou may want to sit back or step out");
			}
			else
			{
				Console.WriteLine("Its a cold day!\nYou may want to sit back and have a cup of coffee");
			}
		}

		//nested if statements
		public static void CheckUser()
		{
			bool userIsRegistered = true;
			bool userIsAdmin = false;
			string userName = "Nkechi";

			Console.WriteLine("Are you a registered user? Yes or No");
			string response = Console.ReadLine();

            if (response.ToLower().Equals("yes"))
			{
				if(userIsRegistered)
				{
					Console.WriteLine("Welcome registered user");

					if(!string.IsNullOrEmpty(userName))
					{
						Console.WriteLine("The name of the registered user is {0}", userName);

						if(!userName.Equals("Uche"))
						{
							Console.WriteLine("{0} is not the admin", userName);
						}
					}
					else
					{
						Console.WriteLine("Username is empty");
					}
				}
				else
				{
					Console.WriteLine("You're not a registered user, hence, an't proceed");
				}
            }
        }
        public static void CheckUserFactorised()
		{
			bool userIsRegisteredF = true;
			bool userIsAdminF = false;
			string userNameF = "Nkechi";

			Console.WriteLine("Are you a registered user? Yes or No");
			string responseF = Console.ReadLine();

			if (responseF.ToLower().Equals("yes") && userIsRegisteredF && !string.IsNullOrEmpty(userNameF) && !userNameF.Equals("Uche"))
			{
				Console.WriteLine("Welcome {0}, you're registered!", userNameF);
			}
			else
			{
                Console.WriteLine("Sorry, you're not registered");
            }
		}
		/*The CheckNumber() below is a method that:
		  -  print "Divisible by 3." when the value is divisible by 3.
		  - prints "Divisible by 7" when it is not divisible by 3, but divisible by 7 print .
		  - Otherwise:
		  - print "Odd number" when it is an odd number,.
		  - if not, print "Even number."*/
		public static void CheckNumber()
		{
			Console.WriteLine("Please enter a number");
			string input = Console.ReadLine();

			bool IsSuccessful = int.TryParse(input, out int result);

			if (IsSuccessful)
			{
				if(result % 3 == 0)
				{
					Console.WriteLine("Divisible by 3");
				}
				else if(result % 3 != 0 && result % 7 == 0)
				{
                    Console.WriteLine("Divisible by 7");
                }
                else if (result % 2 != 0 )
                {
                    Console.WriteLine("Odd number");
                }
				else
				{
                    Console.WriteLine("Even number");
                }
            }
			else
			{
				Console.WriteLine("Wrong input. Please enter a number");
			}
		}

		//Switch Statements
		public static void SafePlanet()
		{
			string safe = "Plant";

			switch (safe)
			{
				case "Plastic":
					Console.WriteLine("Plant not safe with plastic");
					break;

                case "Noise":
                    Console.WriteLine("Plant not safe with Noise");
                    break;

                case "E-waste":
                    Console.WriteLine("Plant not safe with E-waste");
                    break;

                case "Plant":
                    Console.WriteLine("The Planet is very much safe with plants!");
                    break;

                case "Deforestation":
                    Console.WriteLine("Plant not safe with deforestation");
                    break;

					//execute when none of the above cases is true
				default:
					Console.WriteLine("Make the world a safe place");
					break;
            }
		}

		//converting the switch statements to if statements
		public static void SafePlanetWithIf()
		{
            string safe = "Plant";

            if (safe.Equals("Plastic"))
            {
                Console.WriteLine("Plant not safe with plastic");
            }
			else if (safe.Equals("Noise"))
			{
                Console.WriteLine("Plant not safe with Noise");
            }
			else if (safe.Equals("E-waste"))
			{
                Console.WriteLine("Plant not safe with E-waste");
            }
			else if (safe.Equals("Plant"))
            {
                    Console.WriteLine("The Planet is very much safe with plants!");
            }
			else if (safe.Equals("Deforestation"))
			{
                    Console.WriteLine("Plant not safe with deforestation");
            }
			else
			{
                    Console.WriteLine("Make the world a safe place");
            }
        }
    }
}