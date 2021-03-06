#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Diagnostics.Contracts;

namespace MsgPack.Rpc.Protocols
{
	/// <summary>
	///		Holds event data for <see cref="E:MsgPack.Rpc.Server.Protocols.InProcServerTranportManager.Response"/> event.
	/// </summary>
	public sealed class InProcResponseEventArgs : EventArgs
	{
		private readonly byte[] _data;

		/// <summary>
		///		Gets the data of the response.
		/// </summary>
		/// <value>
		///		The data of the response.
		/// </value>
		public byte[] Data
		{
			get { return this._data; }
		}

		/// <summary>
		///		Initializes a new instance of the <see cref="InProcResponseEventArgs"/> class.
		/// </summary>
		/// <param name="data">The data of the response.</param>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="data"/> is <c>null</c>.
		/// </exception>
		public InProcResponseEventArgs( byte[] data )
		{
			if ( data == null )
			{
				throw new ArgumentNullException( "data" );
			}

			Contract.EndContractBlock();

			this._data = data;
		}
	}
}
