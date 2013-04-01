// Copyright 2012 - 2013 dbones.co.uk (David Rundle)
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace Boxes.Test
{
    using System;
    using System.IO;

    public static class TestInfo
    {
        public static string WorkingDirectory 
        { 
            get { return (string) AppDomain.CurrentDomain.GetData(GlobalRegistry.WorkingDirKey); } 
        }

        public static string ModulesDirectory
        {
            get { return Path.Combine((string)AppDomain.CurrentDomain.GetData(GlobalRegistry.WorkingDirKey), GlobalRegistry.ModuleDir); }
        }
    }
}