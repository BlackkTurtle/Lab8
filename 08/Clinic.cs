using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Clinic
    {
        private Pet[] Room;
        private int Index;
        public Clinic(string[] str)
        {
            var a = Convert.ToInt32(str[3]);
            if (a % 2 == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Name=str[2];
                Room = new Pet[a];
                Index = a / 2;
            }
        }
        public string Name { get; set; }
        public void HasEmptyRooms()
        {
            if (Room.Any(c => c == null)){
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public string ReleasePet()
        {
            for (int i = 0; i < Room.Length; i++)
            {
                int curent = (Room.Length / 2 + i) % Room.Length;
                if (Room[curent] != null)
                {
                    Room[curent] = null;
                    return "True";
                }
            }
            return "False";
        }
        public string AddPet(Pet pet)
        {
            for (int i = 0; i < Room.Length; i++)
            {
                int curent = Index;
                IncreaseIndex();
                if (Room[curent] == null)
                {
                    Room[curent] = pet;
                    return "True";
                }
            }
            return "False";
        }
        public void Print()
        {
            for (int i = 0; i < Room.Length; i++)
            {
                Print(i);
            }
        }
        public void Print(int index)
        {
            if (Room[index] != null)
            {
                Console.WriteLine(Room[index]);
            }
            else
            {
                Console.WriteLine("Room empty");
            }
        }
        private void IncreaseIndex()
        {
            int count = Room.Length;
            if (Index == count - 1)
            {
                Index = count / 2;
            }
            else
            {
                if (Index >= count / 2)
                {
                    Index = count / 2 - Index + count / 2 - 1;
                }
                else
                {
                    Index = count / 2 + count / 2 - Index;
                }
            }
        }
    }
}
