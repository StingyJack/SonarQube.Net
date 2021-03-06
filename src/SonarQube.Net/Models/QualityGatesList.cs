﻿using System.Collections.Generic;

namespace SonarQube.Net.Models
{
	public class QualityGatesList
	{
		public IEnumerable<QualityGate> Qualitygates { get; set; }
		public int? Default { get; set; }
		public IDictionary<string, bool?> Actions { get; set; }
	}
}
