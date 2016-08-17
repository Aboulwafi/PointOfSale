﻿using System;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Xunit;

namespace PointOfSale.DomainUnitTests
{
	public class AutoMoqDataAttribute : AutoDataAttribute
	{
		public AutoMoqDataAttribute() : base(new Fixture().Customize(new AutoMoqCustomization()))
		{
		}
	}
}