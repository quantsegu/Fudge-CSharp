﻿/*
 * Copyright (C) 2009 - 2009 by OpenGamma Inc. and other contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 *     
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fudge.Util
{
    /// <summary>
    /// FudgeBinaryWriter provides the wire encoding for primitive types.
    /// </summary>
    /// <remarks>
    /// The default <see cref="BinaryWriter"/> uses little-endian integer encoding, and UTF8, whereas Fudge always
    /// uses Network Byte Order (i.e. big-endian) and modified UTF-8
    /// </remarks>
    public class FudgeBinaryWriter : BinaryNBOWriter
    {
        public FudgeBinaryWriter(Stream output) : base(output, new ModifiedUTF8Encoding())
        {
        }
    }
}
