<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
                xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
                exclude-result-prefixes="msxsl"
                xmlns:Ext="urn:OddsFeedXslExtensions">
  <xsl:output method="xml" indent="yes" encoding="utf-16" omit-xml-declaration="no" standalone="yes" />

  <xsl:template match="/" name="root">
    <xml bookie="Betfredx" 
         xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
         xsi:noNamespaceSchemaLocation="OddFeedSchema.xsd">
      <xsl:attribute name="generateddate">
        <xsl:value-of select="Ext:CurrentDate()" />
      </xsl:attribute>
      <xsl:attribute name="generatedtime">
        <xsl:value-of select="Ext:CurrentTime()" />
      </xsl:attribute>
      <xsl:apply-templates />

    </xml>
  </xsl:template>

  <xsl:template match="category/event" name="events">
    <event>
    </event>
  </xsl:template>


</xsl:stylesheet>
