﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Exceptions;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Model.Zones
{
	/// <summary>
	/// Container object holding all zones owned by one <see cref="Entities.Controller"/>
	/// </summary>
	/// <seealso cref="IEnumerable{IZone}" />
	/// <autogeneratedoc />
	public class ControlledZones : IEnumerable<IZone>
	{
		/// <summary>Gets the owner of the contained zones.</summary>
		/// <value><see cref="Entities.Controller"/></value>
		public Controller Controller { get; private set; }

		/// <summary>Initializes a new instance of the <see cref="ControlledZones"/> class.</summary>
		/// <param name="game">The game.</param>
		/// <param name="controller">The controller.</param>
		/// <autogeneratedoc />
		public ControlledZones(Controller controller)
		{
			Controller = controller;
		}

		/// <summary>Gets the <see cref="IZone"/> matching the zone identifier.</summary>
		/// <value>The <see cref="IZone"/>.</value>
		/// <param name="zone">The zone identifier.</param>
		/// <returns></returns>
		/// <exception cref="ZoneException">There is no zone implemented for the provided identifier</exception>
		public IZone this[Zone zone]
		{
			get
			{
				switch (zone)
				{
					case Zone.GRAVEYARD:
						return Controller.GraveyardZone;
					case Zone.PLAY:
						return Controller.BoardZone;
					case Zone.DECK:
						return Controller.DeckZone;
					case Zone.HAND:
						return Controller.HandZone;
					case Zone.SECRET:
						return Controller.SecretZone;
					case Zone.SETASIDE:
						return Controller.SetasideZone;
					case Zone.REMOVEDFROMGAME:
					case Zone.INVALID:
						return null;
					default:
						throw new ZoneException("No such zone type when creating zone: " + zone);
				}
			}
		}

		public string Hash(params GameTag[] ignore)
		{
			var str = new StringBuilder();
			foreach (IZone zone in this)
				str.Append(zone.Hash(ignore));
			return str.ToString();
		}

		public IEnumerator<IZone> GetEnumerator()
		{
			foreach (Zone zone in Enum.GetValues(typeof(Zone)))
			{
				IZone temp = this[zone];
				if (temp != null)
					yield return temp;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}