﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace NavigationEdgeApi.Navigation
{
	public class ControllerSelector : IHttpControllerSelector
	{
		public IDictionary<string, HttpControllerDescriptor> GetControllerMapping()
		{
			return null;
		}

		public HttpControllerDescriptor SelectController(HttpRequestMessage request)
		{
			return new HttpControllerDescriptor
			{
				Configuration = request.GetConfiguration(),
				ControllerType = Type.GetType("NavigationEdgeApi.Controllers." + request.Properties["controller"] + "Controller")
			};
		}
	}
}