﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    class GlobalState {
        public static GlobalState instance;

        public User currentClient;
        public MainForm mainForm;
        public string imageDirectory;

        public GlobalState() {
            if (instance == null)
                instance = this;

            imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/Images/");
        }
    }
}
