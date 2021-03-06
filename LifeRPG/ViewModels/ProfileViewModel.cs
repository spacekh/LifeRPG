﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeRPG.ViewModels
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public int RewardPoints { get; set; }
        public int XP { get; set; }
    }
}
