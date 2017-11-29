<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html> 
<body>
  <h2>YANTRA BLOCKCHAIN LEDGER</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
     <th style="text-align:left"> ID </th>
      <th style="text-align:left">REQUEST</th>
      <th style="text-align:left">REFERENCE</th>
      <th style="text-align:left">STATE</th>
      <th style="text-align:left">STATUS</th>
    </tr>

    <xsl:for-each select="YANTRA.BLOCKCHAIN/LEDGER/RECORD">
    <tr>
      <td><xsl:value-of select="ID"/></td>
      <td><xsl:value-of select="REQUEST"/></td>
      <td><xsl:value-of select="REFERENCE"/></td>
      <td><xsl:value-of select="STATE"/></td>
      <td><xsl:value-of select="STATUS"/></td>
    </tr>
    </xsl:for-each>

  </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>

