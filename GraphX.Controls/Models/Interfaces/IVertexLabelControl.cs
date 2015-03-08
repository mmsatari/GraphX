﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphX.Controls.Models.Interfaces
{
    public interface IVertexLabelControl
    {
        /// <summary>
        /// Gets or sets label drawing angle in degrees
        /// </summary>
        double Angle { get; set; }

        /// <summary>
        /// Automaticaly update vertex label position
        /// </summary>
        void UpdatePosition();

        void Hide();
        void Show();
    }
}
