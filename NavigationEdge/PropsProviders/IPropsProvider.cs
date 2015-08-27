﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationEdge.PropsProvider
{
	interface IPropsProvider
	{
		IDictionary<string, object> GetProps(dynamic data);
	}
}
