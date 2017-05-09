﻿///*
// *  Licensed to SharpSoftware under one or more contributor
// *  license agreements. See the NOTICE file distributed with this work for 
// *  additional information regarding copyright ownership.
// * 
// *  SharpSoftware licenses this file to you under the Apache License, 
// *  Version 2.0 (the "License"); you may not use this file except in 
// *  compliance with the License. You may obtain a copy of the License at
// * 
// *       http://www.apache.org/licenses/LICENSE-2.0
// * 
// *  Unless required by applicable law or agreed to in writing, software
// *  distributed under the License is distributed on an "AS IS" BASIS,
// *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// *  See the License for the specific language governing permissions and
// *  limitations under the License.
// */

//using Itinero.Algorithms.Collections;
//using Itinero.Algorithms.Contracted.EdgeBased;
//using System;
//using System.Collections.Generic;

//namespace Itinero.Test.Algorithms.Contracted.EdgeBased
//{
//    class MockPriorityCalculator : IPriorityCalculator
//    {
//        private readonly Dictionary<uint, float> _priorities;

//        public MockPriorityCalculator(Dictionary<uint, float> priorities)
//        {
//            _priorities = priorities;
//        }

//        public float Calculate(BitArray32 contractedFlags, Func<uint, IEnumerable<uint[]>> getRestrictions, uint vertex)
//        {
//            return _priorities[vertex];
//        }

//        public void NotifyContracted(uint vertex)
//        {

//        }
//    }
//}