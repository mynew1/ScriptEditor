﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptEditor
{
    public class ScriptAction
    {
        public uint Id;
        public uint Delay;
        public uint Command;
        public uint Datalong;
        public uint Datalong2;
        public uint Datalong3;
        public uint Datalong4;
        public uint BuddyId;
        public uint BuddyRadius;
        public uint BuddyType;
        public uint DataFlags;
        public int Dataint;
        public int Dataint2;
        public int Dataint3;
        public int Dataint4;
        public float X;
        public float Y;
        public float Z;
        public float O;
        public string Comments;
        public ScriptAction(uint id, uint delay, uint command, uint datalong, uint datalong2, uint datalong3, uint datalong4, uint buddyid, uint buddyradius, uint buddytype, uint dataflags, int dataint, int dataint2, int dataint3, int dataint4, float x, float y, float z, float o, string comments)
        {
            Id = id;
            Delay = delay;
            Command = command;
            Datalong = datalong;
            Datalong2 = datalong2;
            Datalong3 = datalong3;
            Datalong4 = datalong4;
            BuddyId = buddyid;
            BuddyRadius = buddyradius;
            BuddyType = buddytype;
            DataFlags = dataflags;
            Dataint = dataint;
            Dataint2 = dataint2;
            Dataint3 = dataint3;
            Dataint4 = dataint4;
            X = x;
            Y = y;
            Z = z;
            O = o;
            Comments = comments;
        }
        public ScriptAction(uint id)
        {
            Id = id;
            Delay = 0;
            Command = 0;
            Datalong = 0;
            Datalong2 = 0;
            Datalong3 = 0;
            Datalong4 = 0;
            BuddyId = 0;
            BuddyRadius = 0;
            BuddyType = 0;
            DataFlags = 0;
            Dataint = 0;
            Dataint2 = 0;
            Dataint3 = 0;
            Dataint4 = 0;
            X = 0;
            Y = 0;
            Z = 0;
            O = 0;
            Comments = "New Action - Edit me!";
        }
    }
}
