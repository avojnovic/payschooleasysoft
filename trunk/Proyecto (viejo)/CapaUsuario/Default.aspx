<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI._Default" culture="auto" meta:resourcekey="PageResource2" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pay School Easy Soft</title>
    <style type="text/css">
        #form1
        {
            height: 419px;
            width: 970px;
            margin-right: 0px;
        }
        .style1
        {
            text-align: center;
            font-weight: bold;
            font-size: medium;
            font-family: "Lucida Console";
            color: #FFFFFF;
            background-color: #3366FF;
            width: 967px;
            height: 20px;
        }
        .style2
        {
            text-align: left;
        }
        .style4
        {
        }
        .style5
        {
            width: 536px;
            font-family: "Lucida Console";
            font-size: 8pt;
            text-align: left;
        }
 p.MsoNormal
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:10.0pt;
	margin-left:0cm;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";
	}
        .style6
        {
            font-family: "Lucida Console";
            font-size: 8pt;
        }
        .style7
        {
            font-size: 8pt;
            text-align: right;
            width: 192px;
            height: 134px;
        }
        .style11
        {
            font-family: "Lucida Console";
            text-align: justify;
        }
        .style14
        {
            width: 300px;
        }
        .style15
        {
            font-size: 8pt;
            width: 192px;
        }
        .style16
        {
            width: 192px;
            height: 46px;
        }
        .style17
        {
            width: 300px;
            font-family: "Lucida Console";
            font-size: 8pt;
            height: 134px;
        }
        .style18
        {
            font-family: "Lucida Console";
            font-size: 8pt;
            height: 46px;
        }
    </style>
</head>
<body>
    <div class="style1">Colegio FASTA San Vicente de Paul</div>
    <form id="form1" runat="server">
    
    <div class="style2">
                </div>
    <table style="width:96%;">
        <tr>
            <td class="style18" colspan="2">
                Bienvenido al sistema de inscripción virtual Pay School Easy Soft de FASTA. En 
                este sitio Ud. podrá realizar las tareas administrativas en la comodidad de su 
                casa.</td>
            <td class="style16">
                <img src="Imagenes/logo colegio.jpg" 
                    
            style="width: 203px; height: 58px; float: right; text-align: center; z-index: 1;" 
                    name="logo" /></td>
        </tr>
        <tr>
            <td class="style17">
        <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333" 
        onauthenticate="Login1_Authenticate" 
                    style="text-align: left; font-family: 'Lucida Console'; font-size: 11pt;" Height="145px" 
                    Width="275px" meta:resourcekey="Login1Resource2">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
    
            </td>
            <td class="style5" rowspan="2">
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;text-align:
justify;line-height:normal; font-family: 'Lucida Console'; font-size: 8pt; font-weight: bold;">
                    <o:p>Perfil Institucional</o:p></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;text-align:
justify;line-height:normal; font-family: 'Lucida Console'; font-size: 8pt; font-weight: bold;">
                    <o:p></o:p></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;text-align:
left; line-height:normal; font-family: 'Lucida Console'; font-size: 8pt;">
                    <o:p>El colegio San Vicente de Paul pertenece a la Fraternidad de Agrupaciones 
                    Santo Tomás de Aquino.</o:p></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;text-align:
left; line-height:normal; font-family: 'Lucida Console'; font-size: 8pt;">
                    <o:p>Cuenta con 20 colegios en todo el país y Universidad.</o:p></p>
                <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;text-align:
left; line-height:normal; font-family: 'Lucida Console'; font-size: 8pt; margin-right: 0cm;">
                    <o:p>Es una institución católica laica fundada en 1962, que responde al 
                    compromiso que la Iglesia pide a los laicos: la evangelización de la familia, la 
                    juventud y la cultura.</o:p></p>
            </td>
            <td class="style7">
                <span class="style11">¿Aún no está registrado?</span><br class="style11" />
                <asp:LinkButton ID="registrarseahoraLB" runat="server" CssClass="style11" 
                    onclick="registrarseahoraLB_Click" meta:resourcekey="registrarseahoraLBResource2" 
                    Text="Registrarse Ahora"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style14">
                </td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" colspan="3">
                <p class="MsoNormal">
                    <b style="mso-bidi-font-weight:normal"><span class="style6">Objetivos Generales<o:p></o:p></span></b></p>
                <span class="style6" 
                    style="line-height: 115%; mso-fareast-font-family: Calibri; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-ansi-language: ES-AR; mso-fareast-language: EN-US; mso-bidi-language: AR-SA; text-align: left;">
                El Colegio FASTA San Vicente de Paul aspira a que el alumno logre una formación 
                basada en la educación de las virtudes.<br />
                Se apoya en una cosmovisión cristiana que intenta realizar la síntesis entre la 
                fe y razón, desarrollando las aptitudes, actitudes y conocimientos necesarios 
                para vivir conforme a la fe en el mundo actual.
                <br />
                Un colegio que se compromete a asistir a los alumnos para que puedan desarrollar 
                en el mayor grado posible su tendencia natural a la perfección.</span><span 
                    class="style11" 
                    style="font-size: 10.0pt; line-height: 115%; mso-fareast-font-family: Calibri; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-ansi-language: ES-AR; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                </span>
            </td>
        </tr>
    </table>
    
    </form>
</body>
</html>
