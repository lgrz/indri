/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version: 1.3.21
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package edu.umass.cs.indri;

import java.util.Map;
public class IndexEnvironment {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected IndexEnvironment(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      indriJNI.delete_IndexEnvironment(swigCPtr);
    }
    swigCPtr = 0;
  }

  protected static long getCPtr(IndexEnvironment obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  public IndexEnvironment() {
    this(indriJNI.new_IndexEnvironment(), true);
  }

  public void setAnchorTextPath(String documentRoot, String anchorTextRoot) {
    indriJNI.IndexEnvironment_setAnchorTextPath(swigCPtr, documentRoot, anchorTextRoot);
  }

  public void addFileClass(String name, String iterator, String parser, String startDocTag, String endDocTag, String endMetadataTag, String[] include, String[] exclude, String[] index, String[] metadata, Map conflations) {
    indriJNI.IndexEnvironment_addFileClass(swigCPtr, name, iterator, parser, startDocTag, endDocTag, endMetadataTag, include, exclude, index, metadata, conflations);
  }

  public void setIndexedFields(String[] fieldNames) {
    indriJNI.IndexEnvironment_setIndexedFields(swigCPtr, fieldNames);
  }

  public void setNumericField(String fieldName, boolean isNumeric) {
    indriJNI.IndexEnvironment_setNumericField(swigCPtr, fieldName, isNumeric);
  }

  public void setMetadataIndexedFields(String[] fieldNames) {
    indriJNI.IndexEnvironment_setMetadataIndexedFields(swigCPtr, fieldNames);
  }

  public void setStopwords(String[] stopwords) {
    indriJNI.IndexEnvironment_setStopwords(swigCPtr, stopwords);
  }

  public void setStemmer(String stemmer) {
    indriJNI.IndexEnvironment_setStemmer(swigCPtr, stemmer);
  }

  public void setMemory(long memory) {
    indriJNI.IndexEnvironment_setMemory(swigCPtr, memory);
  }

  public void create(String repositoryPath, IndexStatus callback) {
    indriJNI.IndexEnvironment_create(swigCPtr, repositoryPath, IndexStatus.getCPtr(callback));
  }

  public void open(String repositoryPath, IndexStatus callback) {
    indriJNI.IndexEnvironment_open(swigCPtr, repositoryPath, IndexStatus.getCPtr(callback));
  }

  public void close() {
    indriJNI.IndexEnvironment_close(swigCPtr);
  }

  public void addFile(String fileName) {
    indriJNI.IndexEnvironment_addFile__SWIG_0(swigCPtr, fileName);
  }

  public void addFile(String fileName, String fileClass) {
    indriJNI.IndexEnvironment_addFile__SWIG_1(swigCPtr, fileName, fileClass);
  }

  public void addString(String fileName, String fileClass, Map metadata) {
    indriJNI.IndexEnvironment_addString(swigCPtr, fileName, fileClass, metadata);
  }

  public void addParsedDocument(ParsedDocument document) {
    indriJNI.IndexEnvironment_addParsedDocument(swigCPtr, document);
  }

}
