﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Surging.Core.CPlatform.Routing.Template
{
    public class RoutePatternParser
    {
        public static string Parse(string routeTemplet, string service, string method, bool routeIsReWriteByServiceRoute = false)
        {
            StringBuilder result = new StringBuilder();
            var parameters = routeTemplet.Split(@"/");
            bool isAppendMethod = false;
            foreach (var parameter in parameters)
            {
                var param = GetParameters(parameter).FirstOrDefault();
                if (param == null)
                {
                    result.Append(parameter.ToLower());
                }
                else if (service.EndsWith(param, StringComparison.OrdinalIgnoreCase))
                {
                    result.Append(service.Substring(1, service.Length - param.Length - 1).ToLower());
                }
                else if ("method".Equals(param, StringComparison.OrdinalIgnoreCase) && !routeIsReWriteByServiceRoute)
                {
                    result.Append(method.ToLower());
                    isAppendMethod = true;
                }
                else
                {
                    if (!isAppendMethod && !routeIsReWriteByServiceRoute)
                    {
                        result.AppendFormat("{0}/", method.ToLower());
                    }
                    result.Append(parameter);
                    isAppendMethod = true;
                }
                result.Append("/");
            }
            result.Length = result.Length - 1;
            if (!isAppendMethod && !routeIsReWriteByServiceRoute) result.AppendFormat("/{0}", method.ToLower());
            return result.ToString(); //result.ToString().ToLower();
        }

        public static string Parse(string routeTemplet, string service)
        {
            StringBuilder result = new StringBuilder();
            var parameters = routeTemplet.Split(@"/");
            foreach (var parameter in parameters)
            {
                var param = GetParameters(parameter).FirstOrDefault();
                if (param == null)
                {
                    result.Append(parameter);
                }
                else if (service.EndsWith(param))
                {
                    result.Append(service.Substring(1, service.Length - param.Length - 1));
                }
                result.Append("/");
            }

            return result.ToString().TrimEnd('/').ToLower();
        }

        private static List<string> GetParameters(string text)
        {
            var matchVale = new List<string>();
            string reg = @"(?<={)[^{}]*(?=})";
            string key = string.Empty;
            foreach (Match m in Regex.Matches(text, reg))
            {
                matchVale.Add(m.Value);
            }
            return matchVale;
        }
    }
}