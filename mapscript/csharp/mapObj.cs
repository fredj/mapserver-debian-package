/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class mapObj : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  internal mapObj(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(mapObj obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  internal static HandleRef getCPtrAndDisown(mapObj obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  internal static HandleRef getCPtrAndSetReference(mapObj obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~mapObj() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        mapscriptPINVOKE.delete_mapObj(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public override bool Equals(object obj) {
    if (obj == null)
        return false;
    if (this.GetType() != obj.GetType())
        return false;
    return swigCPtr.Handle.Equals(mapObj.getCPtr((mapObj)obj).Handle);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public string name {
    set {
      mapscriptPINVOKE.mapObj_name_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.mapObj_name_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int status {
    set {
      mapscriptPINVOKE.mapObj_status_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_status_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int height {
    set {
      mapscriptPINVOKE.mapObj_height_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_height_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int width {
    set {
      mapscriptPINVOKE.mapObj_width_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_width_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int maxsize {
    set {
      mapscriptPINVOKE.mapObj_maxsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_maxsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int refcount {
    get {
      int ret = mapscriptPINVOKE.mapObj_refcount_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int numlayers {
    get {
      int ret = mapscriptPINVOKE.mapObj_numlayers_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int maxlayers {
    get {
      int ret = mapscriptPINVOKE.mapObj_maxlayers_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public symbolSetObj symbolset {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_symbolset_get(swigCPtr);
      symbolSetObj ret = (cPtr == IntPtr.Zero) ? null : new symbolSetObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public fontSetObj fontset {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_fontset_get(swigCPtr);
      fontSetObj ret = (cPtr == IntPtr.Zero) ? null : new fontSetObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public labelCacheObj labelcache {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_labelcache_get(swigCPtr);
      labelCacheObj ret = (cPtr == IntPtr.Zero) ? null : new labelCacheObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int transparent {
    set {
      mapscriptPINVOKE.mapObj_transparent_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_transparent_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int interlace {
    set {
      mapscriptPINVOKE.mapObj_interlace_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_interlace_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int imagequality {
    set {
      mapscriptPINVOKE.mapObj_imagequality_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_imagequality_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public rectObj extent {
    set {
      mapscriptPINVOKE.mapObj_extent_set(swigCPtr, rectObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_extent_get(swigCPtr);
      rectObj ret = (cPtr == IntPtr.Zero) ? null : new rectObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double cellsize {
    set {
      mapscriptPINVOKE.mapObj_cellsize_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.mapObj_cellsize_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MS_UNITS units {
    set {
      mapscriptPINVOKE.mapObj_units_set(swigCPtr, (int)value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      MS_UNITS ret = (MS_UNITS)mapscriptPINVOKE.mapObj_units_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double scaledenom {
    set {
      mapscriptPINVOKE.mapObj_scaledenom_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.mapObj_scaledenom_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double resolution {
    set {
      mapscriptPINVOKE.mapObj_resolution_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.mapObj_resolution_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double defresolution {
    set {
      mapscriptPINVOKE.mapObj_defresolution_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = mapscriptPINVOKE.mapObj_defresolution_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string shapepath {
    set {
      mapscriptPINVOKE.mapObj_shapepath_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.mapObj_shapepath_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string mappath {
    set {
      mapscriptPINVOKE.mapObj_mappath_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.mapObj_mappath_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public colorObj imagecolor {
    set {
      mapscriptPINVOKE.mapObj_imagecolor_set(swigCPtr, colorObj.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_imagecolor_get(swigCPtr);
      colorObj ret = (cPtr == IntPtr.Zero) ? null : new colorObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int numoutputformats {
    get {
      int ret = mapscriptPINVOKE.mapObj_numoutputformats_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public outputFormatObj[] outputformatlist {
    get {
	  IntPtr cPtr = mapscriptPINVOKE.mapObj_outputformatlist_get(swigCPtr);
	  IntPtr objPtr;
      outputFormatObj[] ret = new outputFormatObj[this.numoutputformats];
      for(int cx = 0; cx < this.numoutputformats; cx++) {
          objPtr = System.Runtime.InteropServices.Marshal.ReadIntPtr(cPtr, cx * System.Runtime.InteropServices.Marshal.SizeOf(typeof(IntPtr)));
          ret[cx] = (objPtr == IntPtr.Zero) ? null : new outputFormatObj(objPtr, false, ThisOwn_false());
      }
      
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }

  }

  public outputFormatObj outputformat {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_outputformat_get(swigCPtr);
      outputFormatObj ret = (cPtr == IntPtr.Zero) ? null : new outputFormatObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string imagetype {
    get {
      string ret = mapscriptPINVOKE.mapObj_imagetype_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public referenceMapObj reference {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_reference_get(swigCPtr);
      referenceMapObj ret = (cPtr == IntPtr.Zero) ? null : new referenceMapObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public scalebarObj scalebar {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_scalebar_get(swigCPtr);
      scalebarObj ret = (cPtr == IntPtr.Zero) ? null : new scalebarObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public legendObj legend {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_legend_get(swigCPtr);
      legendObj ret = (cPtr == IntPtr.Zero) ? null : new legendObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public queryMapObj querymap {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_querymap_get(swigCPtr);
      queryMapObj ret = (cPtr == IntPtr.Zero) ? null : new queryMapObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public webObj web {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_web_get(swigCPtr);
      webObj ret = (cPtr == IntPtr.Zero) ? null : new webObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_int layerorder {
    set {
      mapscriptPINVOKE.mapObj_layerorder_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_layerorder_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int debug {
    set {
      mapscriptPINVOKE.mapObj_debug_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = mapscriptPINVOKE.mapObj_debug_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string datapattern {
    set {
      mapscriptPINVOKE.mapObj_datapattern_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.mapObj_datapattern_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string templatepattern {
    set {
      mapscriptPINVOKE.mapObj_templatepattern_set(swigCPtr, value);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mapscriptPINVOKE.mapObj_templatepattern_get(swigCPtr);
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public hashTableObj configoptions {
    get {
      IntPtr cPtr = mapscriptPINVOKE.mapObj_configoptions_get(swigCPtr);
      hashTableObj ret = (cPtr == IntPtr.Zero) ? null : new hashTableObj(cPtr, false, ThisOwn_false());
      if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public mapObj(string filename) : this(mapscriptPINVOKE.new_mapObj(filename), true, null) {
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public mapObj clone() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_clone(swigCPtr);
    mapObj ret = (cPtr == IntPtr.Zero) ? null : new mapObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int insertLayer(layerObj layer, int index) {
    int ret = mapscriptPINVOKE.mapObj_insertLayer(swigCPtr, layerObj.getCPtrAndSetReference(layer, ThisOwn_false()), index);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public layerObj removeLayer(int index) {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_removeLayer(swigCPtr, index);
    layerObj ret = (cPtr == IntPtr.Zero) ? null : new layerObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setExtent(double minx, double miny, double maxx, double maxy) {
    int ret = mapscriptPINVOKE.mapObj_setExtent(swigCPtr, minx, miny, maxx, maxy);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int offsetExtent(double x, double y) {
    int ret = mapscriptPINVOKE.mapObj_offsetExtent(swigCPtr, x, y);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int scaleExtent(double zoomfactor, double minscaledenom, double maxscaledenom) {
    int ret = mapscriptPINVOKE.mapObj_scaleExtent(swigCPtr, zoomfactor, minscaledenom, maxscaledenom);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setCenter(pointObj center) {
    int ret = mapscriptPINVOKE.mapObj_setCenter(swigCPtr, pointObj.getCPtr(center));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setSize(int width, int height) {
    int ret = mapscriptPINVOKE.mapObj_setSize(swigCPtr, width, height);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setRotation(double rotation_angle) {
    int ret = mapscriptPINVOKE.mapObj_setRotation(swigCPtr, rotation_angle);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public layerObj getLayer(int i) {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_getLayer(swigCPtr, i);
    layerObj ret = (cPtr == IntPtr.Zero) ? null : new layerObj(cPtr, true, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public layerObj getLayerByName(string name) {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_getLayerByName(swigCPtr, name);
    layerObj ret = (cPtr == IntPtr.Zero) ? null : new layerObj(cPtr, true, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getSymbolByName(string name) {
    int ret = mapscriptPINVOKE.mapObj_getSymbolByName(swigCPtr, name);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void prepareQuery() {
    mapscriptPINVOKE.mapObj_prepareQuery(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public imageObj prepareImage() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_prepareImage(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setImageType(string imagetype) {
    mapscriptPINVOKE.mapObj_setImageType(swigCPtr, imagetype);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public void selectOutputFormat(string imagetype) {
    mapscriptPINVOKE.mapObj_selectOutputFormat(swigCPtr, imagetype);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOutputFormat(outputFormatObj format) {
    mapscriptPINVOKE.mapObj_setOutputFormat(swigCPtr, outputFormatObj.getCPtr(format));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public imageObj draw() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_draw(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public imageObj drawQuery() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_drawQuery(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public imageObj drawLegend() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_drawLegend(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public imageObj drawScalebar() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_drawScalebar(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public imageObj drawReferenceMap() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_drawReferenceMap(swigCPtr);
    imageObj ret = (cPtr == IntPtr.Zero) ? null : new imageObj(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int embedScalebar(imageObj image) {
    int ret = mapscriptPINVOKE.mapObj_embedScalebar(swigCPtr, imageObj.getCPtr(image));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int embedLegend(imageObj image) {
    int ret = mapscriptPINVOKE.mapObj_embedLegend(swigCPtr, imageObj.getCPtr(image));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int drawLabelCache(imageObj image) {
    int ret = mapscriptPINVOKE.mapObj_drawLabelCache(swigCPtr, imageObj.getCPtr(image));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public labelCacheMemberObj getLabel(int i) {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_getLabel(swigCPtr, i);
    labelCacheMemberObj ret = (cPtr == IntPtr.Zero) ? null : new labelCacheMemberObj(cPtr, false, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public labelCacheMemberObj nextLabel() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_nextLabel(swigCPtr);
    labelCacheMemberObj ret = (cPtr == IntPtr.Zero) ? null : new labelCacheMemberObj(cPtr, false, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int queryByPoint(pointObj point, int mode, double buffer) {
    int ret = mapscriptPINVOKE.mapObj_queryByPoint(swigCPtr, pointObj.getCPtr(point), mode, buffer);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int queryByRect(rectObj rect) {
    int ret = mapscriptPINVOKE.mapObj_queryByRect(swigCPtr, rectObj.getCPtr(rect));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int queryByFeatures(int slayer) {
    int ret = mapscriptPINVOKE.mapObj_queryByFeatures(swigCPtr, slayer);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int queryByShape(shapeObj shape) {
    int ret = mapscriptPINVOKE.mapObj_queryByShape(swigCPtr, shapeObj.getCPtr(shape));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setWKTProjection(string wkt) {
    int ret = mapscriptPINVOKE.mapObj_setWKTProjection(swigCPtr, wkt);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getProjection() {
    string ret = mapscriptPINVOKE.mapObj_getProjection(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setProjection(string proj4) {
    int ret = mapscriptPINVOKE.mapObj_setProjection(swigCPtr, proj4);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int save(string filename) {
    int ret = mapscriptPINVOKE.mapObj_save(swigCPtr, filename);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int saveQuery(string filename) {
    int ret = mapscriptPINVOKE.mapObj_saveQuery(swigCPtr, filename);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int loadQuery(string filename) {
    int ret = mapscriptPINVOKE.mapObj_loadQuery(swigCPtr, filename);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void freeQuery(int qlayer) {
    mapscriptPINVOKE.mapObj_freeQuery(swigCPtr, qlayer);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int saveQueryAsGML(string filename, string ns) {
    int ret = mapscriptPINVOKE.mapObj_saveQueryAsGML(swigCPtr, filename, ns);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getMetaData(string name) {
    string ret = mapscriptPINVOKE.mapObj_getMetaData(swigCPtr, name);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setMetaData(string name, string value) {
    int ret = mapscriptPINVOKE.mapObj_setMetaData(swigCPtr, name, value);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int removeMetaData(string name) {
    int ret = mapscriptPINVOKE.mapObj_removeMetaData(swigCPtr, name);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getFirstMetaDataKey() {
    string ret = mapscriptPINVOKE.mapObj_getFirstMetaDataKey(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getNextMetaDataKey(string lastkey) {
    string ret = mapscriptPINVOKE.mapObj_getNextMetaDataKey(swigCPtr, lastkey);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setSymbolSet(string szFileName) {
    int ret = mapscriptPINVOKE.mapObj_setSymbolSet(swigCPtr, szFileName);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getNumSymbols() {
    int ret = mapscriptPINVOKE.mapObj_getNumSymbols(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setFontSet(string filename) {
    int ret = mapscriptPINVOKE.mapObj_setFontSet(swigCPtr, filename);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int saveMapContext(string szFileName) {
    int ret = mapscriptPINVOKE.mapObj_saveMapContext(swigCPtr, szFileName);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int loadMapContext(string szFileName, int useUniqueNames) {
    int ret = mapscriptPINVOKE.mapObj_loadMapContext(swigCPtr, szFileName, useUniqueNames);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int moveLayerUp(int layerindex) {
    int ret = mapscriptPINVOKE.mapObj_moveLayerUp(swigCPtr, layerindex);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int moveLayerDown(int layerindex) {
    int ret = mapscriptPINVOKE.mapObj_moveLayerDown(swigCPtr, layerindex);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public intarray getLayersDrawingOrder() {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_getLayersDrawingOrder(swigCPtr);
    intarray ret = (cPtr == IntPtr.Zero) ? null : new intarray(cPtr, true, ThisOwn_true());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int setLayersDrawingOrder(SWIGTYPE_p_int panIndexes) {
    int ret = mapscriptPINVOKE.mapObj_setLayersDrawingOrder(swigCPtr, SWIGTYPE_p_int.getCPtr(panIndexes));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setConfigOption(string key, string value) {
    mapscriptPINVOKE.mapObj_setConfigOption(swigCPtr, key, value);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public string getConfigOption(string key) {
    string ret = mapscriptPINVOKE.mapObj_getConfigOption(swigCPtr, key);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void applyConfigOptions() {
    mapscriptPINVOKE.mapObj_applyConfigOptions(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
  }

  public int applySLD(string sld) {
    int ret = mapscriptPINVOKE.mapObj_applySLD(swigCPtr, sld);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int applySLDURL(string sld) {
    int ret = mapscriptPINVOKE.mapObj_applySLDURL(swigCPtr, sld);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string generateSLD() {
    string ret = mapscriptPINVOKE.mapObj_generateSLD(swigCPtr);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string processTemplate(int bGenerateImages, string[] names, string[] values, int numentries) {
    string ret = mapscriptPINVOKE.mapObj_processTemplate(swigCPtr, bGenerateImages, new mapscriptPINVOKE.StringArrayMarshal(names)._ar, new mapscriptPINVOKE.StringArrayMarshal(values)._ar, numentries);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string processLegendTemplate(string[] names, string[] values, int numentries) {
    string ret = mapscriptPINVOKE.mapObj_processLegendTemplate(swigCPtr, new mapscriptPINVOKE.StringArrayMarshal(names)._ar, new mapscriptPINVOKE.StringArrayMarshal(values)._ar, numentries);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string processQueryTemplate(string[] names, string[] values, int numentries) {
    string ret = mapscriptPINVOKE.mapObj_processQueryTemplate(swigCPtr, new mapscriptPINVOKE.StringArrayMarshal(names)._ar, new mapscriptPINVOKE.StringArrayMarshal(values)._ar, numentries);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public outputFormatObj getOutputFormatByName(string name) {
    IntPtr cPtr = mapscriptPINVOKE.mapObj_getOutputFormatByName(swigCPtr, name);
    outputFormatObj ret = (cPtr == IntPtr.Zero) ? null : new outputFormatObj(cPtr, false, ThisOwn_false());
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int appendOutputFormat(outputFormatObj format) {
    int ret = mapscriptPINVOKE.mapObj_appendOutputFormat(swigCPtr, outputFormatObj.getCPtr(format));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int removeOutputFormat(string name) {
    int ret = mapscriptPINVOKE.mapObj_removeOutputFormat(swigCPtr, name);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int loadOWSParameters(OWSRequest request, string wmtver_string) {
    int ret = mapscriptPINVOKE.mapObj_loadOWSParameters(swigCPtr, OWSRequest.getCPtr(request), wmtver_string);
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int OWSDispatch(OWSRequest req) {
    int ret = mapscriptPINVOKE.mapObj_OWSDispatch(swigCPtr, OWSRequest.getCPtr(req));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int zoomPoint(int zoomfactor, pointObj poPixPos, int width, int height, rectObj poGeorefExt, rectObj poMaxGeorefExt) {
    int ret = mapscriptPINVOKE.mapObj_zoomPoint(swigCPtr, zoomfactor, pointObj.getCPtr(poPixPos), width, height, rectObj.getCPtr(poGeorefExt), rectObj.getCPtr(poMaxGeorefExt));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int zoomRectangle(rectObj poPixRect, int width, int height, rectObj poGeorefExt, rectObj poMaxGeorefExt) {
    int ret = mapscriptPINVOKE.mapObj_zoomRectangle(swigCPtr, rectObj.getCPtr(poPixRect), width, height, rectObj.getCPtr(poGeorefExt), rectObj.getCPtr(poMaxGeorefExt));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int zoomScale(double scale, pointObj poPixPos, int width, int height, rectObj poGeorefExt, rectObj poMaxGeorefExt) {
    int ret = mapscriptPINVOKE.mapObj_zoomScale(swigCPtr, scale, pointObj.getCPtr(poPixPos), width, height, rectObj.getCPtr(poGeorefExt), rectObj.getCPtr(poMaxGeorefExt));
    if (mapscriptPINVOKE.SWIGPendingException.Pending) throw mapscriptPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
