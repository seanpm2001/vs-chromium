﻿// Copyright 2015 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;

namespace VsChromium.Settings {
  public class GlobalSettings {
    public bool EnableVsChromiumProjects { get; set; }
    public int MaxTextExtractLength { get; set; }
    public int SearchFileNamesMaxResults { get; set; }
    public int SearchTextMaxResults { get; set; }
    public TimeSpan AutoSearchDelay { get; set; }
  }
}