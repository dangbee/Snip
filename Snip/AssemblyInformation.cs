﻿#region File Information
//-----------------------------------------------------------------------------
// <copyright file="AssemblyInformation.cs" company="David Rudie">
//     Copyright (C) 2013 David Rudie
//
//     This program is free software; you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation; either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//
//     You should have received a copy of the GNU General Public License
//     along with this program; if not, write to the Free Software
//     Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02111, USA.
// </copyright>
//-----------------------------------------------------------------------------
#endregion

namespace Winter
{
    using System;
    using System.Reflection;

    /// <summary>
    /// This class holds information about the program itself.
    /// </summary>
    public static class AssemblyInformation
    {
        /// <summary>
        /// Gets the name of the program from the program.
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute assemblyTitle = (AssemblyTitleAttribute)attributes[0];

                    if (assemblyTitle.Title.Length > 0)
                    {
                        return assemblyTitle.Title;
                    }
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the author of the program from the program.
        /// </summary>
        public static string AssemblyAuthor
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);

                if (attributes.Length > 0)
                {
                    AssemblyCompanyAttribute assemblyAuthor = (AssemblyCompanyAttribute)attributes[0];

                    if (assemblyAuthor.Company.Length > 0)
                    {
                        return assemblyAuthor.Company;
                    }
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the version of the program from the program.
        /// </summary>
        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
    }
}