using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Chummer.Backend.Equipment
{
	/// <summary>
	/// Lifestyle.
	/// </summary>
	public class Lifestyle : INamedItemWithGuid
    {
		private Guid _guiID = new Guid();
		private Guid _sourceID = new Guid();
		private string _strName = string.Empty;
		private int _intCost = 0;
		private int _intDice = 0;
		private int _intMultiplier = 0;
		private int _intMonths = 1;
		private int _intRoommates = 0;
		private int _intPercentage = 100;
		private string _strLifestyleName = string.Empty;
		private bool _blnPurchased = false;
		private int _intEntertainment = 0;
		private int _intComforts = 0;
		private int _intArea = 0;
		private int _intSecurity = 0;
		private int _intComfortsEntertainment = 0;
		private int _intAreaEntertainment = 0;
		private int _intSecurityEntertainment = 0;
		private string _strBaseLifestyle = string.Empty;
		private string _strSource = string.Empty;
		private string _strPage = string.Empty;
		private bool _blnTrustFund = false;
		private LifestyleType _objType = LifestyleType.Standard;
		private List<LifestyleQuality> _lstLifestyleQualities = new List<LifestyleQuality>();
		private List<LifestyleQuality> _lstFreeGrids = new List<LifestyleQuality>();
		private string _strNotes = string.Empty;
		private readonly Character _objCharacter;

		#region Helper Methods
		/// <summary>
		/// Convert a string to a LifestyleType.
		/// </summary>
		/// <param name="strValue">String value to convert.</param>
		public LifestyleType ConverToLifestyleType(string strValue)
		{
			switch (strValue)
			{
				case "BoltHole":
					return LifestyleType.BoltHole;
				case "Safehouse":
					return LifestyleType.Safehouse;
				case "Advanced":
					return LifestyleType.Advanced;
				default:
					return LifestyleType.Standard;
			}
		}
		#endregion

		#region Constructor, Create, Save, Load, and Print Methods
		public Lifestyle(Character objCharacter)
		{
			// Create the GUID for the new Lifestyle.
			_guiID = Guid.NewGuid();
			_objCharacter = objCharacter;
		}

		/// Create a Lifestyle from an XmlNode and return the TreeNodes for it.
		/// <param name="objXmlLifestyle">XmlNode to create the object from.</param>
		/// <param name="objNode">TreeNode to populate a TreeView.</param>
		public void Create(XmlNode objXmlLifestyle, TreeNode objNode)
		{
            objXmlLifestyle.TryGetStringFieldQuickly("name", ref _strName);
            objXmlLifestyle.TryGetInt32FieldQuickly("cost", ref _intCost);
            objXmlLifestyle.TryGetInt32FieldQuickly("dice", ref _intDice);
            objXmlLifestyle.TryGetInt32FieldQuickly("multiplier", ref _intMultiplier);
            objXmlLifestyle.TryGetStringFieldQuickly("source", ref _strSource);
            objXmlLifestyle.TryGetStringFieldQuickly("page", ref _strPage);
			if (!objXmlLifestyle.TryGetField<Guid>("id", Guid.TryParse, out _sourceID))
			{
				Log.Warning(new object[] { "Missing id field for lifestyle xmlnode", objXmlLifestyle});

				if (System.Diagnostics.Debugger.IsAttached)
					System.Diagnostics.Debugger.Break();
			}			 

			objNode.Text = DisplayName;
			objNode.Tag = _guiID;
		}

		/// <summary>
		/// Save the object's XML to the XmlWriter.
		/// </summary>
		/// <param name="objWriter">XmlTextWriter to write with.</param>
		public void Save(XmlTextWriter objWriter)
		{
			objWriter.WriteStartElement("lifestyle");
			objWriter.WriteElementString("guid", _guiID.ToString());
			objWriter.WriteElementString("name", _strName);
			objWriter.WriteElementString("cost", _intCost.ToString());
			objWriter.WriteElementString("dice", _intDice.ToString());
			objWriter.WriteElementString("baselifestyle", _strBaseLifestyle);
			objWriter.WriteElementString("multiplier", _intMultiplier.ToString());
			objWriter.WriteElementString("months", _intMonths.ToString());
			objWriter.WriteElementString("roommates", _intRoommates.ToString());
			objWriter.WriteElementString("percentage", _intPercentage.ToString());
			objWriter.WriteElementString("lifestylename", _strLifestyleName);
			objWriter.WriteElementString("purchased", _blnPurchased.ToString());
			objWriter.WriteElementString("comforts", _intComforts.ToString());
			objWriter.WriteElementString("area", _intArea.ToString());
			objWriter.WriteElementString("security", _intSecurity.ToString());
			objWriter.WriteElementString("comfortsentertainment", _intComfortsEntertainment.ToString());
			objWriter.WriteElementString("areaentertainment", _intAreaEntertainment.ToString());
			objWriter.WriteElementString("securityentertainment", _intSecurityEntertainment.ToString());
			objWriter.WriteElementString("entertainment", _intEntertainment.ToString());
			objWriter.WriteElementString("source", _strSource);
			objWriter.WriteElementString("page", _strPage);
			objWriter.WriteElementString("trustfund", _blnTrustFund.ToString()); 
			objWriter.WriteElementString("type", _objType.ToString());
			objWriter.WriteElementString("sourceid", SourceID.ToString());
			objWriter.WriteStartElement("lifestylequalities");
			foreach (LifestyleQuality objQuality in _lstLifestyleQualities)
			{
				objQuality.Save(objWriter);
			}
			objWriter.WriteEndElement();
			objWriter.WriteStartElement("freegrids");
			foreach (LifestyleQuality objQuality in _lstFreeGrids)
			{
				objQuality.Save(objWriter);
			}
			objWriter.WriteEndElement();
			objWriter.WriteElementString("notes", _strNotes);
			objWriter.WriteEndElement();
			_objCharacter.SourceProcess(_strSource);
		}

		/// <summary>
		/// Load the CharacterAttribute from the XmlNode.
		/// </summary>
		/// <param name="objNode">XmlNode to load.</param>
		public void Load(XmlNode objNode, bool blnCopy = false)
		{
			//Can't out property and no backing field
			Guid source;
			if (objNode.TryGetField<Guid>("sourceid", Guid.TryParse, out source))
			{
				SourceID = source;
			}

            if (blnCopy)
            {
                _guiID = Guid.NewGuid();
                _intMonths = 0;
            }
            else
            {
                objNode.TryGetInt32FieldQuickly("months", ref _intMonths);
                objNode.TryGetField<Guid>("guid", Guid.TryParse, out _guiID);
            }

		    objNode.TryGetStringFieldQuickly("name", ref _strName);
		    objNode.TryGetInt32FieldQuickly("cost", ref _intCost);
		    objNode.TryGetInt32FieldQuickly("dice", ref _intDice);
		    objNode.TryGetInt32FieldQuickly("multiplier", ref _intMultiplier);

			objNode.TryGetInt32FieldQuickly("area", ref _intArea);
			objNode.TryGetInt32FieldQuickly("security", ref _intSecurity);
			objNode.TryGetInt32FieldQuickly("comforts", ref _intComforts);
			objNode.TryGetInt32FieldQuickly("roommates", ref _intRoommates);
			objNode.TryGetInt32FieldQuickly("percentage", ref _intPercentage);
			objNode.TryGetStringFieldQuickly("lifestylename", ref _strLifestyleName);
		    objNode.TryGetBoolFieldQuickly("purchased", ref _blnPurchased);

            if (objNode.TryGetStringFieldQuickly("baselifestyle", ref _strBaseLifestyle))
			{
				if (_strBaseLifestyle == "Middle")
					_strBaseLifestyle = "Medium";
			}

		    objNode.TryGetStringFieldQuickly("source", ref _strSource);
            objNode.TryGetBoolFieldQuickly("trustfund", ref _blnTrustFund);
			objNode.TryGetStringFieldQuickly("page", ref _strPage);

			// Lifestyle Qualities
			XmlNodeList objXmlNodeList = objNode.SelectNodes("lifestylequalities/lifestylequality");
			foreach (XmlNode objXmlQuality in objXmlNodeList)
			{
				LifestyleQuality objQuality = new LifestyleQuality(_objCharacter);
				objQuality.Load(objXmlQuality);
				_lstLifestyleQualities.Add(objQuality);
			}

			// Free Grids provided by the Lifestyle
			objXmlNodeList = objNode.SelectNodes("freegrids/lifestylequality");
			foreach (XmlNode objXmlQuality in objXmlNodeList)
			{
				LifestyleQuality objQuality = new LifestyleQuality(_objCharacter);
				objQuality.Load(objXmlQuality);
				_lstLifestyleQualities.Add(objQuality);
			}

			objNode.TryGetStringFieldQuickly("notes", ref _strNotes);

			String strtemp = string.Empty;
			if (objNode.TryGetStringFieldQuickly("type", ref strtemp))
			{
				_objType = ConverToLifestyleType(strtemp);
			}
		}

		/// <summary>
		/// Print the object's XML to the XmlWriter.
		/// </summary>
		/// <param name="objWriter">XmlTextWriter to write with.</param>
		public void Print(XmlTextWriter objWriter)
		{
			objWriter.WriteStartElement("lifestyle");
			objWriter.WriteElementString("name", DisplayNameShort);
			objWriter.WriteElementString("cost", _intCost.ToString());
			objWriter.WriteElementString("totalmonthlycost", TotalMonthlyCost.ToString());
			objWriter.WriteElementString("totalcost", TotalCost.ToString());
			objWriter.WriteElementString("dice", _intDice.ToString());
			objWriter.WriteElementString("multiplier", _intMultiplier.ToString());
			objWriter.WriteElementString("months", _intMonths.ToString());
			objWriter.WriteElementString("purchased", _blnPurchased.ToString());
			objWriter.WriteElementString("lifestylename", _strLifestyleName);
			objWriter.WriteElementString("type", _objType.ToString());
			objWriter.WriteElementString("sourceid", SourceID.ToString());
			string strBaseLifestyle = string.Empty;

			// Retrieve the Advanced Lifestyle information if applicable.
			if (!string.IsNullOrEmpty(_strBaseLifestyle))
			{
				XmlDocument objXmlDocument = XmlManager.Instance.Load("lifestyles.xml");

				XmlNode objXmlAspect = objXmlDocument.SelectSingleNode("/chummer/lifestyles/lifestyle[id = \"" + SourceID + "\"]");
			    if (objXmlAspect != null)
			    {
			        if (objXmlAspect["translate"] != null)
			            strBaseLifestyle = objXmlAspect["translate"].InnerText;
			        else if (objXmlAspect["name"] != null)
			            strBaseLifestyle = objXmlAspect["name"].InnerText;
			    }
			}

			objWriter.WriteElementString("baselifestyle", strBaseLifestyle);
			objWriter.WriteElementString("trustfund", _blnTrustFund.ToString());
			objWriter.WriteElementString("source", _objCharacter.Options.LanguageBookShort(_strSource));
			objWriter.WriteElementString("page", Page);
			objWriter.WriteStartElement("qualities");

			// Retrieve the Qualities for the Advanced Lifestyle if applicable.
			if (_lstLifestyleQualities.Count > 0)
			{
				foreach (LifestyleQuality objQuality in _lstLifestyleQualities)
				{
					objQuality.Print(objWriter);
				}
			}
			// Retrieve the free Grids for the Advanced Lifestyle if applicable.
			if (_lstFreeGrids.Count > 0)
			{
				foreach (LifestyleQuality objQuality in _lstFreeGrids)
				{
					string strThisQuality = objQuality.DisplayName;
					objWriter.WriteElementString("quality", strThisQuality);
				}
			}
			objWriter.WriteEndElement();
			if (_objCharacter.Options.PrintNotes)
				objWriter.WriteElementString("notes", _strNotes);
			objWriter.WriteEndElement();
		}
		#endregion

		#region Properties
		/// <summary>
		/// Internal identifier which will be used to identify this Lifestyle in the Improvement system.
		/// </summary>
		public string InternalId
		{
			get
			{
				return _guiID.ToString();
			}
		}

		public List<LifestyleQuality> FreeGrids
		{
			get
			{
				return _lstFreeGrids;
			}
			set
			{
				_lstFreeGrids = value;
			}
		}

		public Guid SourceID {
			get
			{
				return _sourceID;
			}
			set
			{
				if (_sourceID != Guid.Empty)
				{
					throw new InvalidOperationException("Source ID can only be set once");
				}

				_sourceID = value;
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name
		{
			get
			{
				return _strName;
			}
			set
			{
				_strName = value;
			}
		}

		/// <summary>
		/// The name of the object as it should be displayed on printouts (translated name only).
		/// </summary>
		public string DisplayNameShort
		{
			get
			{
				string strReturn = _strName;
				// Get the translated name if applicable.
				if (GlobalOptions.Instance.Language != "en-us")
				{
					XmlDocument objXmlDocument = XmlManager.Instance.Load("lifestyles.xml");
					XmlNode objNode = objXmlDocument.SelectSingleNode("/chummer/lifestyles/lifestyle[id = \"" + SourceID.ToString().TrimStart('{').TrimEnd('}') + "\"]");
					if (objNode != null)
					{
						if (objNode["translate"] != null)
							strReturn = objNode["translate"].InnerText;
					}
				}

				return strReturn;
			}
		}

		/// <summary>
		/// The name of the object as it should be displayed in lists. Name (Extra).
		/// </summary>
		public string DisplayName
		{
			get
			{
				string strReturn = DisplayNameShort;

				if (!string.IsNullOrEmpty(_strLifestyleName))
					strReturn += " (\"" + _strLifestyleName + "\")";

				return strReturn;
			}
		}

		/// <summary>
		/// Sourcebook.
		/// </summary>
		public string Source
		{
			get
			{
				return _strSource;
			}
			set
			{
				_strSource = value;
			}
		}

		/// <summary>
		/// Sourcebook Page Number.
		/// </summary>
		public string Page
		{
			get
			{
				string strReturn = _strPage;
				// Get the translated name if applicable.
				if (GlobalOptions.Instance.Language != "en-us")
				{
					XmlDocument objXmlDocument = XmlManager.Instance.Load("lifestyles.xml");
					XmlNode objNode = objXmlDocument.SelectSingleNode("/chummer/lifestyles/lifestyle[id = \"" + SourceID.ToString().TrimStart('{').TrimEnd('}') + "\"]");
					if (objNode != null)
					{
						if (objNode["altpage"] != null)
							strReturn = objNode["altpage"].InnerText;
					}
				}

				return strReturn;
			}
			set
			{
				_strPage = value;
			}
		}

		/// <summary>
		/// Cost.
		/// </summary>
		public int Cost
		{
			get
			{
				return _intCost;
			}
			set
			{
				_intCost = value;
			}
		}

		/// <summary>
		/// Number of dice the character rolls to determine their statring Nuyen.
		/// </summary>
		public int Dice
		{
			get
			{
				return _intDice;
			}
			set
			{
				_intDice = value;
			}
		}

		/// <summary>
		/// Number the character multiplies the dice roll with to determine their starting Nuyen.
		/// </summary>
		public int Multiplier
		{
			get
			{
				return _intMultiplier;
			}
			set
			{
				_intMultiplier = value;
			}
		}

		/// <summary>
		/// Months purchased.
		/// </summary>
		public int Months
		{
			get
			{
				return _intMonths;
			}
			set
			{
				_intMonths = value;
			}
		}

		/// <summary>
		/// Whether or not the Lifestyle has been Purchased and no longer rented.
		/// </summary>
		public bool Purchased
		{
			get
			{
				return _blnPurchased;
			}
			set
			{
				_blnPurchased = value;
			}
		}

		/// <summary>
		/// Base Lifestyle.
		/// </summary>
		public string BaseLifestyle
		{
			get
			{
				return _strBaseLifestyle;
			}
			set
			{
				_strBaseLifestyle = value;
			}
		}
		/// <summary>
		/// Advance Lifestyle Comforts.
		/// </summary>
		public int Comforts
		{
			get
			{
				return _intComforts;
			}
			set
			{
				_intComforts = value;
			}
		}
		/// <summary>
		/// Advance Lifestyle Comforts.
		/// </summary>
		public int ComfortsEntertainment
		{
			get
			{
				return _intComfortsEntertainment;
			}
			set
			{
				_intComfortsEntertainment = value;
			}
		}

		/// <summary>
		/// Advance Lifestyle Neighborhood Entertainment.
		/// </summary>
		public int AreaEntertainment
		{
			get
			{
				return _intAreaEntertainment;
			}
			set
			{
				_intAreaEntertainment = value;
			}
		}

		/// <summary>
		/// Advance Lifestyle Security Entertainment.
		/// </summary>
		public int SecurityEntertainment
		{
			get
			{
				return _intSecurityEntertainment;
			}
			set
			{
				_intSecurityEntertainment = value;
			}
		}
		/// <summary>
		/// Advance Lifestyle Comforts.
		/// </summary>
		public int Entertainment
		{
			get
			{
				return _intEntertainment;
			}
			set
			{
				_intEntertainment = value;
			}
		}

		/// <summary>
		/// Advance Lifestyle Neighborhood.
		/// </summary>
		public int Area
		{
			get
			{
				return _intArea;
			}
			set
			{
				_intArea = value;
			}
		}

		/// <summary>
		/// Advance Lifestyle Security.
		/// </summary>
		public int Security
		{
			get
			{
				return _intSecurity;
			}
			set
			{
				_intSecurity = value;
			}
		}
		/// <summary>
		/// Advanced Lifestyle Qualities.
		/// </summary>
		public List<LifestyleQuality> LifestyleQualities
		{
			get
			{
				return _lstLifestyleQualities;
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes
		{
			get
			{
				return _strNotes;
			}
			set
			{
				_strNotes = value;
			}
		}

		/// <summary>
		/// A custom name for the Lifestyle assigned by the player.
		/// </summary>
		public string LifestyleName
		{
			get
			{
				return _strLifestyleName;
			}
			set
			{
				_strLifestyleName = value;
			}
		}

		/// <summary>
		/// Type of the Lifestyle.
		/// </summary>
		public LifestyleType StyleType
		{
			get
			{
				return _objType;
			}
			set
			{
				_objType = value;
			}
		}

		/// <summary>
		/// Number of Roommates this Lifestyle is shared with.
		/// </summary>
		public int Roommates
		{
			get
			{
				return _intRoommates;
			}
			set
			{
				_intRoommates = value;
			}
		}

		/// <summary>
		/// Percentage of the total cost the character pays per month.
		/// </summary>
		public int Percentage
		{
			get
			{
				return _intPercentage;
			}
			set
			{
				_intPercentage = value;
			}
		}

		/// <summary>
		/// Whether the lifestyle is currently covered by the Trust Fund Quality.
		/// </summary>
		public bool TrustFund
		{
			get
			{
				return _blnTrustFund;
			}
			set
			{
				_blnTrustFund = value;
			}
		}
		#endregion

		#region Complex Properties
		/// <summary>
		/// Total cost of the Lifestyle, counting all purchased months.
		/// </summary>
		public int TotalCost
		{
			get
			{
				return TotalMonthlyCost * _intMonths;
			}
		}

		/// <summary>
		/// Total monthly cost of the Lifestyle.
		/// </summary>
		public int TotalMonthlyCost
		{
			get
			{
				int intReturn = 0;
				//TODO: Should we really be returning a cached unvalidated value here?
				if (_objType != LifestyleType.Standard)
				{
					intReturn = Cost;
					return intReturn;
				}

				ImprovementManager objImprovementManager = new ImprovementManager(_objCharacter);
				decimal decMultiplier = 1;
				decMultiplier = Convert.ToDecimal(objImprovementManager.ValueOf(Improvement.ImprovementType.LifestyleCost), GlobalOptions.InvariantCultureInfo);
				if (_objType == LifestyleType.Standard)
					decMultiplier += Convert.ToDecimal(objImprovementManager.ValueOf(Improvement.ImprovementType.BasicLifestyleCost), GlobalOptions.InvariantCultureInfo);
                decimal decExtraMultiplierBaseOnly = 0;

				decimal decBaseCost = Cost;
                decimal decExtraAssetCost = 0;
				decimal decConstractCost = 0;
				foreach (LifestyleQuality objQuality in _lstLifestyleQualities)
				{
					//Add the flat cost from Qualities.
					if (!objQuality.Free)
					{
						if (objQuality.Cost > 0)
						{
							if (objQuality.Category == "Contracts")
								decConstractCost += objQuality.Cost;
							else
								decExtraAssetCost += objQuality.Cost;
						}
						//Add the percentage point modifiers from Qualities.
						decMultiplier += objQuality.Multiplier;
						//Add the percentage point modifiers from Qualities.
						decExtraMultiplierBaseOnly += objQuality.BaseMultiplier;
					}
				}

				decMultiplier += _intRoommates * 10;
				decMultiplier = 1 + Convert.ToDecimal(decMultiplier / 100, GlobalOptions.InvariantCultureInfo);
                decExtraMultiplierBaseOnly = Convert.ToDecimal(decExtraMultiplierBaseOnly / 100, GlobalOptions.InvariantCultureInfo);

                double dblPercentage = Convert.ToDouble(_intPercentage, GlobalOptions.InvariantCultureInfo) / 100.0;

                int intBaseLifestyleCost = Convert.ToInt32(decBaseCost * (decMultiplier + decExtraMultiplierBaseOnly));
                if (!_blnTrustFund)
                {
                    intReturn += intBaseLifestyleCost;
                }
                intReturn += Convert.ToInt32(decExtraAssetCost * decMultiplier);
				intReturn = Convert.ToInt32(intReturn * dblPercentage);
                intReturn += Convert.ToInt32(decConstractCost);
				return intReturn;
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Set the InternalId for the Lifestyle. Used when editing an Advanced Lifestyle.
		/// </summary>
		/// <param name="strInternalId">InternalId to set.</param>
		public void SetInternalId(string strInternalId)
		{
			_guiID = Guid.Parse(strInternalId);
		}
		#endregion
	}
}