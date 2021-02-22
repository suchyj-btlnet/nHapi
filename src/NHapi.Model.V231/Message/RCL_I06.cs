using System;
using System.Collections.Generic;
using NHapi.Base.Log;
using NHapi.Model.V231.Group;
using NHapi.Model.V231.Segment;
using NHapi.Model.V231.Datatype;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V231.Message

{
///<summary>
/// Represents a RCL_I06 message structure (see chapter [AAA]). This structure contains the 
/// following elements:
///<ol>
///<li>0: MSH (MSH - message header segment) </li>
///<li>1: MSA (MSA - message acknowledgment segment) </li>
///<li>2: QRD (QRD - original-style query definition segment) </li>
///<li>3: QRF (QRF - original style query filter segment) optional </li>
///<li>4: RCL_I06_PROVIDER (a Group object) repeating</li>
///<li>5: PID (PID - patient identification segment) </li>
///<li>6: DG1 (DG1 - diagnosis segment) optional repeating</li>
///<li>7: DRG (DRG - diagnosis related group segment) optional repeating</li>
///<li>8: AL1 (AL1 - patient allergy information segment) optional repeating</li>
///<li>9: NTE (NTE - notes and comments segment) optional repeating</li>
///<li>10: DSP (DSP - display data segment) optional repeating</li>
///<li>11: DSC (DSC - Continuation pointer segment) optional </li>
///</ol>
///</summary>
[Serializable]
public class RCL_I06 : AbstractMessage  {

	///<summary> 
	/// Creates a new RCL_I06 Group with custom IModelClassFactory.
	///</summary>
	public RCL_I06(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new RCL_I06 Group with DefaultModelClassFactory. 
	///</summary> 
	public RCL_I06() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for RCL_I06.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(RCL_I06_PROVIDER), true, true);
	      this.add(typeof(PID), true, false);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, true);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(DSP), false, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RCL_I06 - this is probably a bug in the source code generator.", e);
	   }
	}


	public override string Version
		{
			get{
			return Constants.VERSION;
			}
		}
	///<summary>
	/// Returns MSH (MSH - message header segment) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns MSA (MSA - message acknowledgment segment) - creates it if necessary
	///</summary>
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.GetStructure("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRD (QRD - original-style query definition segment) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRF (QRF - original style query filter segment) - creates it if necessary
	///</summary>
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RCL_I06_PROVIDER (a Group object) - creates it if necessary
	///</summary>
	public RCL_I06_PROVIDER GetPROVIDER() {
	   RCL_I06_PROVIDER ret = null;
	   try {
	      ret = (RCL_I06_PROVIDER)this.GetStructure("PROVIDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RCL_I06_PROVIDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RCL_I06_PROVIDER GetPROVIDER(int rep) { 
	   return (RCL_I06_PROVIDER)this.GetStructure("PROVIDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RCL_I06_PROVIDER 
	 */ 
	public int PROVIDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PROVIDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RCL_I06_PROVIDER results 
	 */ 
	public IEnumerable<RCL_I06_PROVIDER> PROVIDERs 
	{ 
		get
		{
			for (int rep = 0; rep < PROVIDERRepetitionsUsed; rep++)
			{
				yield return (RCL_I06_PROVIDER)this.GetStructure("PROVIDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new RCL_I06_PROVIDER
	///</summary>
	public RCL_I06_PROVIDER AddPROVIDER()
	{
		return this.AddStructure("PROVIDER") as RCL_I06_PROVIDER;
	}

	///<summary>
	///Removes the given RCL_I06_PROVIDER
	///</summary>
	public void RemovePROVIDER(RCL_I06_PROVIDER toRemove)
	{
		this.RemoveStructure("PROVIDER", toRemove);
	}

	///<summary>
	///Removes the RCL_I06_PROVIDER at the given index
	///</summary>
	public void RemovePROVIDERAt(int index)
	{
		this.RemoveRepetition("PROVIDER", index);
	}

	///<summary>
	/// Returns PID (PID - patient identification segment) - creates it if necessary
	///</summary>
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.GetStructure("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
	///</summary>
	public DG1 GetDG1() {
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.GetStructure("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DG1
	/// * (DG1 - diagnosis segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DG1 GetDG1(int rep) { 
	   return (DG1)this.GetStructure("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DG1 results 
	 */ 
	public IEnumerable<DG1> DG1s 
	{ 
		get
		{
			for (int rep = 0; rep < DG1RepetitionsUsed; rep++)
			{
				yield return (DG1)this.GetStructure("DG1", rep);
			}
		}
	}

	///<summary>
	///Adds a new DG1
	///</summary>
	public DG1 AddDG1()
	{
		return this.AddStructure("DG1") as DG1;
	}

	///<summary>
	///Removes the given DG1
	///</summary>
	public void RemoveDG1(DG1 toRemove)
	{
		this.RemoveStructure("DG1", toRemove);
	}

	///<summary>
	///Removes the DG1 at the given index
	///</summary>
	public void RemoveDG1At(int index)
	{
		this.RemoveRepetition("DG1", index);
	}

	///<summary>
	/// Returns  first repetition of DRG (DRG - diagnosis related group segment) - creates it if necessary
	///</summary>
	public DRG GetDRG() {
	   DRG ret = null;
	   try {
	      ret = (DRG)this.GetStructure("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DRG
	/// * (DRG - diagnosis related group segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DRG GetDRG(int rep) { 
	   return (DRG)this.GetStructure("DRG", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DRG 
	 */ 
	public int DRGRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DRG").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DRG results 
	 */ 
	public IEnumerable<DRG> DRGs 
	{ 
		get
		{
			for (int rep = 0; rep < DRGRepetitionsUsed; rep++)
			{
				yield return (DRG)this.GetStructure("DRG", rep);
			}
		}
	}

	///<summary>
	///Adds a new DRG
	///</summary>
	public DRG AddDRG()
	{
		return this.AddStructure("DRG") as DRG;
	}

	///<summary>
	///Removes the given DRG
	///</summary>
	public void RemoveDRG(DRG toRemove)
	{
		this.RemoveStructure("DRG", toRemove);
	}

	///<summary>
	///Removes the DRG at the given index
	///</summary>
	public void RemoveDRGAt(int index)
	{
		this.RemoveRepetition("DRG", index);
	}

	///<summary>
	/// Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary
	///</summary>
	public AL1 GetAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.GetStructure("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of AL1
	/// * (AL1 - patient allergy information segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public AL1 GetAL1(int rep) { 
	   return (AL1)this.GetStructure("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the AL1 results 
	 */ 
	public IEnumerable<AL1> AL1s 
	{ 
		get
		{
			for (int rep = 0; rep < AL1RepetitionsUsed; rep++)
			{
				yield return (AL1)this.GetStructure("AL1", rep);
			}
		}
	}

	///<summary>
	///Adds a new AL1
	///</summary>
	public AL1 AddAL1()
	{
		return this.AddStructure("AL1") as AL1;
	}

	///<summary>
	///Removes the given AL1
	///</summary>
	public void RemoveAL1(AL1 toRemove)
	{
		this.RemoveStructure("AL1", toRemove);
	}

	///<summary>
	///Removes the AL1 at the given index
	///</summary>
	public void RemoveAL1At(int index)
	{
		this.RemoveRepetition("AL1", index);
	}

	///<summary>
	/// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (NTE - notes and comments segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of DSP (DSP - display data segment) - creates it if necessary
	///</summary>
	public DSP GetDSP() {
	   DSP ret = null;
	   try {
	      ret = (DSP)this.GetStructure("DSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of DSP
	/// * (DSP - display data segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public DSP GetDSP(int rep) { 
	   return (DSP)this.GetStructure("DSP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DSP 
	 */ 
	public int DSPRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("DSP").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the DSP results 
	 */ 
	public IEnumerable<DSP> DSPs 
	{ 
		get
		{
			for (int rep = 0; rep < DSPRepetitionsUsed; rep++)
			{
				yield return (DSP)this.GetStructure("DSP", rep);
			}
		}
	}

	///<summary>
	///Adds a new DSP
	///</summary>
	public DSP AddDSP()
	{
		return this.AddStructure("DSP") as DSP;
	}

	///<summary>
	///Removes the given DSP
	///</summary>
	public void RemoveDSP(DSP toRemove)
	{
		this.RemoveStructure("DSP", toRemove);
	}

	///<summary>
	///Removes the DSP at the given index
	///</summary>
	public void RemoveDSPAt(int index)
	{
		this.RemoveRepetition("DSP", index);
	}

	///<summary>
	/// Returns DSC (DSC - Continuation pointer segment) - creates it if necessary
	///</summary>
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.GetStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}