<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

	<!--xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template-->

	<xsl:template match="/ArrayOfOrder">
		<html>
			<head>
				<title>
					Orders
				</title>
			</head>
			<body>
				<h3>Orders:</h3>
				<ul>
					<xsl:for-each select="Order">
						<hr/>
						Id: <xsl:value-of select="Id"/><br/>
						Client: <xsl:value-of select="Client/Name"/> Phone: <xsl:value-of select="Client/PhoneNumber"/><br/>
						Cost: <xsl:value-of select="Cost"/><br/>
						Details: 						
						<ul>
							<table border="true">
								<tr>
									<th>Product Name</th>
									<th>Product Price</th>
									<th>Count</th>
								</tr>
								<xsl:for-each select="List/OrderDetails">
									<tr>
										<td>
											<xsl:value-of select="ProductName"/>
										</td>
										<td>
											<xsl:value-of select="ProductPrice"/>
										</td>
										<td>
											<xsl:value-of select="Count"/>
										</td>
									</tr>
								</xsl:for-each>
							</table>
						</ul>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
	
</xsl:stylesheet>
