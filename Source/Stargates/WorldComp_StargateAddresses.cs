﻿using System;
using RimWorld;
using RimWorld.Planet;
using Verse;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace StargatesMod
{
    public class WorldComp_StargateAddresses : WorldComponent
    {
        public List<int> addressList = new List<int>();

        public WorldComp_StargateAddresses(World world) : base(world) { }

        public void RemoveAddress(int address)
        {
            addressList.Remove(address);
        }

        public void AddAddress(int address)
        {
            if (!addressList.Contains(address))
            {
                addressList.Add(address);
            }
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Collections.Look(ref addressList, "addressList");
        }
    }
}
