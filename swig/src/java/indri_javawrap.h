/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.23
 * 
 * This file is not intended to be easily readable and contains a number of 
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG 
 * interface file instead. 
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_indri_WRAP_H_
#define SWIG_indri_WRAP_H_

struct SwigDirector_IndexStatus : public IndexStatus, public Swig::Director {

public:
    void swig_connect_director(JNIEnv *jenv, jobject jself, jclass jcls);
    SwigDirector_IndexStatus(JNIEnv *jenv);
    virtual void status(int code, std::string const &documentPath, std::string const &error, int documentsIndexed, int documentsSeen);
public:
    bool swig_overrides(int n) {
      return (n < 1 ? swig_override[n] : false);
    }
protected:
    bool swig_override[1];
};


#endif
