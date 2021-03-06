﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace FluentAssemblyScanner
{
    public abstract class FilterDefinerBase
    {
        protected FilterDefinerBase(List<Type> types)
        {
            AndFilter = type => true;
            MethodFilters = info => true;
        }

        protected Predicate<Type> AndFilter;
        protected Predicate<MethodInfo> MethodFilters;

        public abstract List<Type> Scan();

        public FilterDefinerBase Where(Predicate<Type> filter)
        {
            AndFilter += filter;
            return this;
        }
    }
}