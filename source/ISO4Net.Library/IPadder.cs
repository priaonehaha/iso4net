﻿/*
 * 
 * ISO4Net - http://openeft.codeplex.com/
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


using System;


namespace ISO4Net.Library {

    /// <summary>
    /// Basic interface for pad handling
    /// </summary>
    public interface IPadder {

        /// <summary>
        /// Pad the string up to the specified max length
        /// </summary>
        /// <param name="data">String to pad</param>
        /// <param name="maxLength">Maximum length</param>
        string Pad(string data, int maxLength);

        /// <summary>
        /// Removes padding from a padded string
        /// </summary>
        /// <param name="paddedData">Padded string</param>
        string Unpad(String paddedData);

    }
}
