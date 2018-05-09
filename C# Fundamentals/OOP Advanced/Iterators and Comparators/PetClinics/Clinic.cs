using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


public class Clinic
{
    private Pet[] rooms;
    private string name;
    public Clinic(string name, Pet[] rooms)
    {
        Name = name;
        Rooms = rooms;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (value.Length < 1 ||
                value.Length > 50 ||
                !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("invalid name");
            }

            name = value;
        }
    }

    public Pet[] Rooms
    {
        get => rooms;
        private set
        {
            if (value.Length % 2 == 0)
                throw new ArgumentException("rooms are not odd");

            rooms = value;
        }
    }

    public bool Add(Pet pet)
    {
        var i = Rooms.Length != 1 ? Rooms.Length / 2 : 0;

        var steps = 1;
        while (steps <= Rooms.Length)
        {
            if (Rooms[i] == null)
            {
                Rooms[i] = pet;
                return true;
            }
            if (steps % 2 == 0)
                i += steps;
            else
            {
                i -= steps;
            }
            steps++;
        }

        return false;
    }

    public bool Release()
    {
        for (int i = Rooms.Length / 2; i < Rooms.Length; i++)
        {
            if (Rooms[i] != null)
            {
                Rooms[i] = null;
                return true;
            }

            if (i == Rooms.Length - 1)
                i = -1;
        }

        return false;
    }

    public bool HasEmptyRooms()
    {
        if (Rooms.Any(x => x == null))
            return true;
        return false;
    }
    public void Print(int room)
    {
        if (room == 0)
        {
            foreach (var t in Rooms)
            {
                Console.WriteLine(t == null ? "Room empty" : t.ToString());
            }
        }
        else
        {
            Console.WriteLine(Rooms[room-1] == null ? "Room empty" : Rooms[room-1].ToString());
        }
    }
}

