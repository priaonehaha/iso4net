﻿/*
 * 
 * ISO4Net - http://github.com/iso4Net
 * Copyright (C) 2014 Robert Barreiro (rbarreiro@gmail.com)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

using ISO4Net.Library.Padders;
using ISO4Net.Library.Prefixers;
using ISO4Net.Library.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISO4Net.Library.Encoders {

    /// <summary>
    /// Vairable ASCII Char, with 3 bytes prefix
    /// </summary>
    public class LLLA_Char : ISOStringFieldEncoder {

        #region Properties

        public override int Length {
            get {
                return base.Length;
            }
            set {
                CheckLength(value, 999);
                base.Length = value;
            }
        }

        #endregion

        #region LLLA_Char

        public LLLA_Char() : base(PaddingNone.Instance, PrefixASCII.LLL, TranslatorASCII.Instance) { }

        public LLLA_Char(int len, string name) : base(len, name, PaddingNone.Instance, PrefixASCII.LLL, TranslatorASCII.Instance) { }

        #endregion

    }
}
