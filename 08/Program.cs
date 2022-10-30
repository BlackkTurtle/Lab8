using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clinics = new List <Clinic>();
            var pets=new List<Pet>();
            while (true)
            {
                string[] str=Console.ReadLine().Split(' ');
                if (str[0] == "Create")
                {
                    if (str[1] == "Pet")
                    {
                        pets.Add(new Pet(str));
                    }
                    else
                    {
                        clinics.Add(new Clinic(str));
                    }
                }else if(str[0] == "Add")
                {
                    for (int i = 0; i < clinics.Count; i++)
                    {
                        if (clinics[i].Name == str[2])
                        {
                            for (int j = 0; j < pets.Count; j++)
                            {
                                if (pets[j].Name == str[1])
                                {
                                    Console.WriteLine(clinics[i].AddPet(pets[j]));
                                }
                            }
                        }
                    }
                }else if (str[0] == "Release")
                {
                    for (int i = 0; i < clinics.Count; i++)
                    {
                        if (clinics[i].Name == str[1])
                        {
                            Console.WriteLine(clinics[i].ReleasePet());
                        }
                    }
                }else if (str[0] == "HasEmptyRooms")
                {
                    for (int i = 0; i < clinics.Count; i++)
                    {
                        if (clinics[i].Name == str[1])
                        {
                            clinics[i].HasEmptyRooms();
                        }
                    }
                }else if (str[0] == "Print")
                {
                    if (str.Length == 2)
                    {
                        for (int i = 0; i < clinics.Count; i++)
                        {
                            if (clinics[i].Name == str[1])
                            {
                                clinics[i].Print();
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < clinics.Count; i++)
                        {
                            if (clinics[i].Name == str[1])
                            {
                                clinics[i].Print(Convert.ToInt32(str[2]));
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
