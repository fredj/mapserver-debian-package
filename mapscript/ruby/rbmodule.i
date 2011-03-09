/******************************************************************************
 * $Id: rbmodule.i 5197 2006-02-15 17:47:33Z sdlime $
 *
 * Project:  MapServer
 * Purpose:  Ruby-specific enhancements to MapScript
 * Author:   
 *
 ******************************************************************************
 *
 * Ruby-specific mapscript code has been moved into this 
 * SWIG interface file to improve the readibility of the main
 * interface file.  The main mapscript.i file includes this
 * file when SWIGRUBY is defined (via 'swig -ruby ...').
 *
 *****************************************************************************/

/******************************************************************************
 * Simple Typemaps
 *****************************************************************************/
/* To support imageObj::getBytes */
%typemap(out) gdBuffer {
    $result = rb_str_new($1.data, $1.size);
    gdFree($1.data);
}