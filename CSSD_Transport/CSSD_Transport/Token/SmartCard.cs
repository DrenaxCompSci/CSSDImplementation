﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSSD_Transport.Accounts;

namespace CSSD_Transport.Token
{
	class SmartCard : Token
	{
		public Accounts.Account getAccount()
		{
			//TODO: Account is top-level and token is a passenger class
			//Account also needs to be protected to be accessed properly
		}
	}
}
