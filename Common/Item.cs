﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroDAQ.Common
{
    public class Item
    {
        public int ID { get; internal protected set; }
        public ItemType Type { get; internal protected set; }
        public ItemState State { get; internal protected set; }
        public int DataTick { get; internal protected set; }
        public int SyncTick { get; set; }
        public DateTime DataTime { get; internal protected set; }
        public DateTime SyncTime { get; internal protected set; }
        public float Value { get; internal protected set; }
        public short Quality { get; internal protected set; }
    }
}
