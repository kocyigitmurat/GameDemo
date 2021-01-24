using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;

namespace GameDemo.Entities
{
    public class Sales:ISales
    {
        public string Id { get; set; }
        public string GameName { get; set; }
        public int count { get; set; }

    }
}
