﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE-IdentityServer4-EntityFramework in the project root for license information.

// Project: Abp.ZeroCore.IdentityServer4.Configuration
// File: IdentityClaim.cs
// 
// Copyright 2018 Mjollnir<mjollnir@59k.org>
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
namespace Abp.IdentityServer4.Entities
{
    public class IdentityClaim : UserClaim
    {
        public IdentityResource IdentityResource { get; set; }
    }
}
