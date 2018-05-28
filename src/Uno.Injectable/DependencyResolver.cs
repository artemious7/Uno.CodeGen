﻿// ******************************************************************
// Copyright � 2015-2018 nventive inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// ******************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
	/// <summary>
	/// Encapsulates a method that that resolves an dependency given its type and optional name.
	/// </summary>
	/// <param name="type">The type of the dependency.</param>
	/// <param name="name">The optional name of the dependency.</param>
	/// <returns></returns>
	public delegate object DependencyResolver(Type type, string name = null);
}