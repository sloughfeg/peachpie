﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Peachpie.Library.PDO.Utilities
{
    /// <summary>
    /// Extension methods to <see cref="PDO"/>.
    /// </summary>
    public static class PdoExtension
    {
        /// <summary>
        /// Gets last created command.
        /// </summary>
        public static DbCommand GetCurrentCommand(this PDO pdo) => pdo.CurrentCommand;

        /// <summary>
        /// Creates command using provided PDO driver.
        /// </summary>
        public static DbCommand CreateCommand(this PDO pdo, string statement) => pdo.CreateCommand(statement);
    }
}