using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task9();
            //Task10();
            //Task8();
            //Task7();
            //Task11();
            //Task12();
            //Task13();
            //VurmaCedveli();
            Task14();
        }


        static void Task1()
        {

          
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

           

                int countofa = 0;
                int index = text.IndexOf('a');
                while (index != -1)
                {
                    countofa++;
                    index = text.IndexOf('a', index + 1);

                }
            int countofb = 0;
            int index1 = text.IndexOf('b');
            while (index1 != -1)
            {

                countofb++;
                index1 = text.IndexOf('b', index1 + 1);


            }

            int dif = countofa / countofb;

            Console.WriteLine(dif);



        }

        static void Task2()
        {

            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?

            Console.Write("Enter a text which contains 'a': ");
            string text = Console.ReadLine();

           
            int index = text.IndexOf('a')+1;

            

                if (index != -1 && index % 2 != 0)
                {
                Console.WriteLine("All 'a' letters are in an odd place");



            }

                
                else
                {
                    Console.WriteLine("No, not all of them are in odd place");


                }
                
            }
        
        
        static void Task3()
        {
            //Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
            Console.Write("Enter a text which contains 'b': ");
            string text = Console.ReadLine();

            int index = text.IndexOf('b') + 1;



            
                int countofb = 0;
                while(index != -1&& index % 2 != 0)
                {
                    countofb += 1;
                    index = text.IndexOf('b', index + 1);

                }

                Console.WriteLine(countofb);
           

        }

        static void Task4()
        {
            //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?

            Console.Write("Enter a text which contains 'a': ");
            string text = Console.ReadLine();


            
            int index = text.IndexOf('a');
            
            
                if (index % 2 != 0)
                {

                    Console.WriteLine("Cut");
                    


                }

                else {
                    Console.WriteLine("Tek");
                     
                     }
    

        }


        static void Task5()
        {

            //5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?

            Console.Write("Enter a text which contains 'a','b','c': ");
            string text = Console.ReadLine();

            
            if (text.IndexOf('a')==1){

                Console.WriteLine("First letter comes a");



            }
            else if(text.IndexOf('b') == 1)
            {

                Console.WriteLine("First letter comes b");
            }
            else if (text.IndexOf('c') == 1)
            {

                Console.WriteLine("First letter comes b");
            }

            else
            {

                Console.WriteLine("None of them");
            }


        }

        static void Task6()
        {

            //6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            l1:
            Console.Write("Enter a text which contains 'a': ");
            string text = Console.ReadLine();
            int solIndex = text.IndexOf('a');
            int sagIndex = text.LastIndexOf('a');

            if (solIndex != -1 && sagIndex != -1)
            {
                if (solIndex == sagIndex)
                {
                    Console.WriteLine("Left and right indexes are the same.");
                }
                else
                {
                    Console.WriteLine("Left and right indexes are not the same.");
                }
            }
            else
            {
                Console.WriteLine("'{a}' there is no a character.");
                goto l1;
            }

            
        }
         
        static void Task7()
        {

            //7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
            Console.Write("Icinde a b c herifleri olan metn daxil edin: ");
            string text = Console.ReadLine();

            int index1 = text.IndexOf('a');
            int index2 = text.IndexOf('b');
            int index3 = text.IndexOf('c');


            if (index1 != -1 && index2 != -1 && index3 != -1)
            {

                if(index1<index2&& index2 < index3)
                {

                    Console.WriteLine("Birinci a gelir onnan sonra b onnan sonra c");

                }
                else
                {


                    Console.WriteLine("A herifi B den qabag gelmelidi, B herifide C den evvel gelmelidir");


                }

             



            }

            else {


                Console.WriteLine("Verilen cumlede a,b,c herifleri yoxdu");
                    
                    
                    }



        }

        static void Task9()
        {

            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();
            string Netice = "";
            foreach (char c in Metn)
            {
                if (char.IsLetter(c))
                {
                    Netice += c;
                }
            }

            Console.WriteLine(Netice);


        }
        static void Task10()
        {

            Console.Write("Enter a text with digits: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length;)
            {
                if (char.IsDigit(text[i]))
                {
                    text = text.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(text);
        }

        static void Task8()
        {

            string text = Console.ReadLine();

            int indexOfA = text.IndexOf('a');

            if (indexOfA != -1 && indexOfA < text.Length - 1)
            {
                char nextChar = text[indexOfA + 1];


                for (int i = 0; i < 10; i++)
                {
                    Console.Write(nextChar);
                    

                }
                

            }

            
            else
            {
                Console.WriteLine("'a' not found or it's the last character in the input text.");
            }

        }

        static void Task11()
        {
            Console.Write("Metn daxil edin: ");
            string Metn = Console.ReadLine();


            string deyisilmismetn = "";

            foreach (char c in Metn)
            {

                if (c == 'a')
                {
                    deyisilmismetn += 'b';
                }


                deyisilmismetn += c;
            }



            Console.WriteLine("Yeni metn: " + deyisilmismetn);
        }
        static void Task12()
        {
            //12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. 
            l1:
            Console.Write("Input a text with a letters ");
            string text = Console.ReadLine();

            Console.WriteLine(text);
            int firstAIndex = text.IndexOf('a');

           
            if (firstAIndex != -1)
            {
                
                int lastAIndex = text.LastIndexOf('a');

                
                if (firstAIndex == lastAIndex)
                Console.WriteLine(text); 

                
                string middleSection = text.Substring(firstAIndex + 1, lastAIndex - (firstAIndex + 1));

                
                string modifiedStr = text.Substring(0, firstAIndex + 1) + middleSection.Replace("a", "") + text.Substring(lastAIndex);


                Console.WriteLine(modifiedStr);
            }

            else
            {
                Console.WriteLine("There is no a in the text: ");
                goto l1;
            }

            
        }

        static void Task13()
        {

        //13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. 
      
            string text = Console.ReadLine();

            string newText = "";
            
            for (int i = 0; i < text.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                    newText += Char.ToUpper(text[i]);

                }
                else
                {

                    newText += Char.ToLower(text[i]);

                }
                

            }

            Console.WriteLine(newText);
        }

        static void Task14()
        {


            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 


            string text = Console.ReadLine();

            for (int i = 0; i < text.Length -1; i++)
            {
                char x = text[i+1];

                if (char.IsLetter(x))
                {




                    if (i % 2 == 0)
                    {

                        text = text.Remove(i, 1);
                        text = text.Insert(i, Char.ToUpper(x).ToString());


                    }

                }

            }

            Console.WriteLine(text);
        }

        static void VurmaCedveli()
        {
            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= 10; b++)
                {
                    Console.WriteLine("{0}x{1}", a, b, a * b);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }


    }

    }



    
    

    
