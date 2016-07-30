<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt"
                exclude-result-prefixes="msxsl"
                xmlns:Ext="urn:OddsFeedXslExtensions">
  <xsl:output method="xml" indent="yes" encoding="utf-16" omit-xml-declaration="no" standalone="yes" />

  <xsl:template match="/" name="root">
    <xml bookie="Bet365"
         xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
         xsi:noNamespaceSchemaLocation="OddFeedSchema.xsd">
      <xsl:attribute name="generateddate">
        <xsl:value-of select="Ext:CurrentDate()" />
      </xsl:attribute>
      <xsl:attribute name="generatedtime">
        <xsl:value-of select="Ext:CurrentTime()" />
      </xsl:attribute>

      <xsl:attribute name="sport">
        <xsl:value-of select="Ext:GetSport()" />
      </xsl:attribute>

      <xsl:attribute name="feedname">
        <xsl:value-of select="Ext:GetFeedName()" />
      </xsl:attribute>

      <xsl:attribute name="feedtype">
        <xsl:value-of select="Ext:GetFeedType()" />
      </xsl:attribute>
      <xsl:apply-templates />

    </xml>
  </xsl:template>

  <xsl:template match="Sport/Event" name="events">
    <event>
      <xsl:attribute name="name">
        <xsl:value-of select="Ext:DoEventSubstitutions('HorseRacing',@Name)" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@ID" />
      </xsl:attribute>
      <xsl:attribute name="date">
        <xsl:value-of select="Ext:ParseBet365EventDate(@OffTime)" />
      </xsl:attribute>
      <xsl:attribute name="meeting">
      </xsl:attribute>
      <xsl:attribute name="venue">
      </xsl:attribute>
      <xsl:apply-templates />
    </event>
  </xsl:template>

  <xsl:template match="Market" name="market">
    <market>
      <xsl:attribute name="name">
        <xsl:value-of select="@Name" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@ID" />
      </xsl:attribute>
      <xsl:attribute name="start">
        <xsl:value-of select="Ext:ParseBet365EventDate(../@OffTime)" />
      </xsl:attribute>
      <xsl:attribute name="inplay">
      </xsl:attribute>
      <xsl:attribute name="suspended">
      </xsl:attribute>
      <xsl:attribute name="ewplaces">
        <xsl:value-of select="../@PlaceCount" />
      </xsl:attribute>
      <xsl:attribute name="ewreduction">
        <xsl:value-of select="../@PlaceOdds" />
      </xsl:attribute>
      <xsl:apply-templates />
    </market>
  </xsl:template>

  <xsl:template match="Participant" name="selection">
    <sel>
      <xsl:attribute name="name">
        <xsl:value-of select="@Name" />
      </xsl:attribute>
      <xsl:attribute name="id">
        <xsl:value-of select="@ID" />
      </xsl:attribute>
      <xsl:apply-templates />
      <xsl:attribute name="price">
        <xsl:value-of select="@Odds" />
      </xsl:attribute>
    </sel>
  </xsl:template>


</xsl:stylesheet>
