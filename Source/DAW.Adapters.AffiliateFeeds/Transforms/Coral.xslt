<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:Extensions="urn:Extensions" exclude-result-prefixes="msxsl">

  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/oxip/response" name="root">
    <terraformed>
      <xsl:apply-templates />
    </terraformed>
  </xsl:template>

 
  <xsl:template match="event">
    <event>
      <xsl:attribute name="sport">
        <xsl:value-of select="Extensions:ExtractSport(@category)"/>
      </xsl:attribute>
      <xsl:attribute name="competition">
        <xsl:value-of select="@typeName"/>
      </xsl:attribute>
      <xsl:attribute name="name">
        <xsl:value-of select="Extensions:ExtractTeamNames(@name)"/>
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id"/>
      </xsl:attribute>
      <xsl:attribute name="date">
        <xsl:value-of select="Extensions:CompileCoralEventTime(@date,@time)"/>
      </xsl:attribute>
      <xsl:attribute name="suspend">
        <xsl:value-of select="Extensions:GenericFlag(@suspend)"/>
      </xsl:attribute>
      <xsl:attribute name="cashout">
        <xsl:value-of select="Extensions:GenericFlag(@cashoutAvailable)"/>
      </xsl:attribute>
      <xsl:apply-templates />
    </event>
  </xsl:template>

  <xsl:template match="market">
    <market>
      <xsl:attribute name="name">
        <xsl:value-of select="Extensions:SubstituteTeamNames(@name,../@name)"/>
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id"/>
      </xsl:attribute>
      <xsl:apply-templates />
    </market>
  </xsl:template>


  <xsl:template match="outcome">
    <selection>
      <xsl:attribute name="name">
        <xsl:value-of select="Extensions:SubstituteTeamNames(@name,../../@name)"/>
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@id"/>
      </xsl:attribute>
      <xsl:attribute name="price">
        <xsl:value-of select="@odds"/>
      </xsl:attribute>
    </selection>
  </xsl:template>




</xsl:stylesheet>
