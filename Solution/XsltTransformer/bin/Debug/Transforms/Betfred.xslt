<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:SportsbookExtensions="urn:OddsFeedXslExtensions">
  <xsl:output method="xml" indent="yes" encoding="utf-16" omit-xml-declaration="no" standalone="yes" />

  <xsl:template match="/" name="root">
    <xml>
      <xsl:apply-templates />
    </xml>
  </xsl:template>

  <xsl:template match="event" name="events">
    <xsl:call-template name="eventprocessing" />
  </xsl:template>


</xsl:stylesheet>
