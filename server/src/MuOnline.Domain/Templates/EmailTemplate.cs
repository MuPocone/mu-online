namespace MuOnline.Domain.Templates
{
    public struct EmailTemplate
    {
        public struct ConfirmacaoCadastro
        {
            public const string Assunto = "Confirmar cadastro";

            public const string Mensagem = @"
            <!DOCTYPE html>
                <html lang='en'>

                <head>
                  <meta charset='UTF-8' />
                  <meta http-equiv='X-UA-Compatible' content='IE=edge' />
                  <meta name='viewport' content='width=device-width, initial-scale=1.0' />
                  <title>Document</title>
                </head>

                <body>
                  <table cellpadding='0' cellspacing='0' border='0' width='100%' class='x_x_wrapper' bgcolor='#ffffff'
                    style='table-layout: fixed; width: 100% !important'>
                    <tbody>
                      <tr>
                        <td valign='top' bgcolor='#ffffff' width='100%' style=''>
                          <table width='100%' role='content-container' class='x_x_outer' align='center' cellpadding='0' cellspacing='0'
                            border='0'>
                            <tbody>
                              <tr>
                                <td width='100%'>
                                  <table width='100%' cellpadding='0' cellspacing='0' border='0'>
                                    <tbody>
                                      <tr>
                                        <td>
                                          <table width='100%' cellpadding='0' cellspacing='0' border='0' align='center'
                                            style='width: 100%; max-width: 500px'>
                                            <tbody>
                                              <tr>
                                                <td role='modules-container' bgcolor='#201E1E' width='100%' align='left'
                                                  style='padding: 0px 20px; text-align: left; color: rgb(0, 0, 0)'>
                                                  <table class='x_x_module x_x_preheader x_x_preheader-hide' role='module' border='0'
                                                    cellpadding='0' cellspacing='0' width='100%'
                                                    style='visibility: hidden; opacity: 0; height: 0px; width: 0px; color: transparent; display: none !important'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content'>
                                                          <p
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px'>
                                                          </p>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' bgcolor='#201E1E' style='padding: 0px 0px 20px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_wrapper' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%'
                                                    style='table-layout: fixed; width: 100% !important; table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td valign='top' align='center'
                                                          style='font-size: 6px; line-height: 10px; padding: 10px 0px 0px 0px'>
                                                          <img data-imagetype='External' src='{0}' class='x_x_max-width' border='0'
                                                            alt='' width='230' height=''
                                                            style='display: block; text-decoration: none; font-family: Helvetica, arial, sans-serif; font-size: 16px; color: rgb(255, 255, 255); max-width: 100% !important' />
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <!-- <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0' width='100%' style='table-layout: fixed'>
                                                      <tbody>
                                                        <tr>
                                                          <td height='100%' valign='top' style='padding: 18px 0px 18px 0px; line-height: 22px; text-align: justify'>
                                                            <div style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                              <div style='font-size: 14px; color: rgb(0, 0, 0); font-family: inherit; text-align: center'>
                                                                <span style='font-size: 42px; text-align: center; padding-top: 0cm; padding-right: 0cm; padding-bottom: 0cm; padding-left: 0cm'><strong _msthash='37284390' _msttexthash='242632'>Titulo</strong></span>
                                                              </div>
                                                              <div style='font-size: 14px; color: rgb(0, 0, 0); font-family: inherit; text-align: center'>
                                                                <span style='font-size: 20px; text-align: center; padding-top: 0cm; padding-right: 0cm; padding-bottom: 0cm; padding-left: 0cm' _msthash='37284391' _msttexthash='1935531'>Sub titulo&nbsp;</span>
                                                              </div>
                                                              <div style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'></div>
                                                            </div>
                                                          </td>
                                                        </tr>
                                                      </tbody>
                                                    </table> -->
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td height='100%' valign='top'
                                                          style='padding: 18px 0px 18px 0px; line-height: 22px; text-align: justify'>
                                                          <div
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            <div
                                                              style='font-size: 14px; color: rgb(255, 255, 255); font-family: inherit; text-align: center'
                                                              _msthash='37284392' _msttexthash='539604'>
                                                              E ai, {1}!
                                                              </br>
                                                              Tudo bem? Esperamos que sim.
                                                              </br>
                                                            </div>
                                                            <div
                                                              style='font-size: 14px; color: rgb(255, 255, 255); font-family: inherit; text-align: center'
                                                              _msthash='37284393' _msttexthash='7664241'>
                                                              Muito obrigado por se cadastrar. Para nós é um prazer poder
                                                              contribuir com a sua diversão.
                                                              </br>
                                                              Trabalhamos com muita dedicação para que todos se divirtam.
                                                              </br>
                                                              Para começar a jogar, valide seu e-mail de cadastro.
                                                            </div>
                                                            <div
                                                              style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            </div>
                                                          </div>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table border='0' cellpadding='0' cellspacing='0' class='x_x_module' role='module'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td align='center' class='x_x_outer-td' style='padding: 0px 0px 0px 0px'>
                                                          <table border='0' cellpadding='0' cellspacing='0'
                                                            class='x_x_button-css__deep-table___2OZyb x_x_wrapper-mobile'
                                                            style='text-align: center'>
                                                            <tbody>
                                                              <tr>
                                                                <td align='center' bgcolor='#a0a0a0' class='x_x_inner-td'
                                                                  style='border-radius: 6px; font-size: 16px; text-align: center; background-color: inherit'>
                                                                  <a href='{2}/confirmar?hash={3}'
                                                                    target='_blank' rel='noopener noreferrer' data-auth='NotApplicable'
                                                                    style='background-color: rgb(33, 224, 157); border: 1px solid rgb(33, 224, 157); border-radius: 6px; color: rgb(32, 30, 30); display: inline-block; font-family: arial, helvetica, sans-serif; font-size: 16px; font-weight: normal; letter-spacing: 0px; line-height: 16px; padding: 12px 18px; text-align: center; text-decoration: none'
                                                                    data-linkindex='0' _msthash='42548220' _msttexthash='215410'>Validar
                                                                    e-mail</a>
                                                                </td>
                                                              </tr>
                                                            </tbody>
                                                          </table>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' style='padding: 0px 0px 10px 0px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td height='100%' valign='top'>
                                                          <div
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            <div class='x_x_Unsubscribe--addressLine'
                                                              style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                              <p class='x_x_Unsubscribe--senderName'
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'>
                                                              </p>
                                                              <p
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px'>
                                                              </p>
                                                              <p
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'>
                                                                <span class='x_x_Unsubscribe--senderAddress'></span><span
                                                                  class='x_x_Unsubscribe--senderCity'></span><span
                                                                  class='x_x_Unsubscribe--senderState'></span><span
                                                                  class='x_x_Unsubscribe--senderZip'></span>
                                                              </p>
                                                            </div>
                                                            <p style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'
                                                              _msthash='36583560' _msttexthash='1484041'>
                                                              <a href='{2}/privacy-policy'
                                                                target='_blank' rel='noopener noreferrer' data-auth='NotApplicable'
                                                                class='x_x_Unsubscribe--unsubscribeLink'
                                                                style='color: rgb(33, 224, 157); text-decoration: none'
                                                                data-linkindex='1'>Política de Privacidade</a>
                                                            </p>
                                                          </div>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' style='padding: 0px 0px 10px 0px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' bgcolor='#201E1E' style='padding: 0px 0px 20px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </td>
                                      </tr>
                                    </tbody>
                                  </table>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </body> 
                </html> 
        ";
        }

        public struct RecuperarSenha
        {
            public const string Assunto = "Recuperar senha";

            public const string Mensagem = @"
            <!DOCTYPE html>
                <html lang='en'>

                <head>
                  <meta charset='UTF-8' />
                  <meta http-equiv='X-UA-Compatible' content='IE=edge' />
                  <meta name='viewport' content='width=device-width, initial-scale=1.0' />
                  <title>Document</title>
                </head>

                <body>
                  <table cellpadding='0' cellspacing='0' border='0' width='100%' class='x_x_wrapper' bgcolor='#ffffff'
                    style='table-layout: fixed; width: 100% !important'>
                    <tbody>
                      <tr>
                        <td valign='top' bgcolor='#ffffff' width='100%' style=''>
                          <table width='100%' role='content-container' class='x_x_outer' align='center' cellpadding='0' cellspacing='0'
                            border='0'>
                            <tbody>
                              <tr>
                                <td width='100%'>
                                  <table width='100%' cellpadding='0' cellspacing='0' border='0'>
                                    <tbody>
                                      <tr>
                                        <td>
                                          <table width='100%' cellpadding='0' cellspacing='0' border='0' align='center'
                                            style='width: 100%; max-width: 500px'>
                                            <tbody>
                                              <tr>
                                                <td role='modules-container' bgcolor='#201E1E' width='100%' align='left'
                                                  style='padding: 0px 20px; text-align: left; color: rgb(0, 0, 0)'>
                                                  <table class='x_x_module x_x_preheader x_x_preheader-hide' role='module' border='0'
                                                    cellpadding='0' cellspacing='0' width='100%'
                                                    style='visibility: hidden; opacity: 0; height: 0px; width: 0px; color: transparent; display: none !important'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content'>
                                                          <p
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px'>
                                                          </p>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' bgcolor='#201E1E' style='padding: 0px 0px 20px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_wrapper' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%'
                                                    style='table-layout: fixed; width: 100% !important; table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td valign='top' align='center'
                                                          style='font-size: 6px; line-height: 10px; padding: 10px 0px 0px 0px'>
                                                          <img data-imagetype='External' src='{0}' class='x_x_max-width' border='0'
                                                            alt='' width='230' height=''
                                                            style='display: block; text-decoration: none; font-family: Helvetica, arial, sans-serif; font-size: 16px; color: rgb(255, 255, 255); max-width: 100% !important' />
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <!-- <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0' width='100%' style='table-layout: fixed'>
                                                      <tbody>
                                                        <tr>
                                                          <td height='100%' valign='top' style='padding: 18px 0px 18px 0px; line-height: 22px; text-align: justify'>
                                                            <div style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                              <div style='font-size: 14px; color: rgb(0, 0, 0); font-family: inherit; text-align: center'>
                                                                <span style='font-size: 42px; text-align: center; padding-top: 0cm; padding-right: 0cm; padding-bottom: 0cm; padding-left: 0cm'><strong _msthash='37284390' _msttexthash='242632'>Titulo</strong></span>
                                                              </div>
                                                              <div style='font-size: 14px; color: rgb(0, 0, 0); font-family: inherit; text-align: center'>
                                                                <span style='font-size: 20px; text-align: center; padding-top: 0cm; padding-right: 0cm; padding-bottom: 0cm; padding-left: 0cm' _msthash='37284391' _msttexthash='1935531'>Sub titulo&nbsp;</span>
                                                              </div>
                                                              <div style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'></div>
                                                            </div>
                                                          </td>
                                                        </tr>
                                                      </tbody>
                                                    </table> -->
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td height='100%' valign='top'
                                                          style='padding: 18px 0px 18px 0px; line-height: 22px; text-align: justify'>
                                                          <div
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            <div
                                                              style='font-size: 14px; color: rgb(255, 255, 255); font-family: inherit; text-align: center'
                                                              _msthash='37284392' _msttexthash='539604'>
                                                              E ai, {1}!
                                                              </br>
                                                              Tudo bem? Esperamos que sim.
                                                              </br>
                                                            </div>
                                                            <div
                                                              style='font-size: 14px; color: rgb(255, 255, 255); font-family: inherit; text-align: center'
                                                              _msthash='37284393' _msttexthash='7664241'>
                                                              Viemos relembrar tua senha!
                                                            </br>
                                                              Senha: {2}
                                                            </div>
                                                            <div
                                                              style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            </div>
                                                          </div>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table> 
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' style='padding: 0px 0px 10px 0px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td height='100%' valign='top'>
                                                          <div
                                                            style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                            <div class='x_x_Unsubscribe--addressLine'
                                                              style='font-family: arial, helvetica, sans-serif; font-size: 14px; color: rgb(0, 0, 0)'>
                                                              <p class='x_x_Unsubscribe--senderName'
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'>
                                                              </p>
                                                              <p
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px'>
                                                              </p>
                                                              <p
                                                                style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'>
                                                                <span class='x_x_Unsubscribe--senderAddress'></span><span
                                                                  class='x_x_Unsubscribe--senderCity'></span><span
                                                                  class='x_x_Unsubscribe--senderState'></span><span
                                                                  class='x_x_Unsubscribe--senderZip'></span>
                                                              </p>
                                                            </div>
                                                            <p style='font-family: arial, helvetica, sans-serif; font-size: 14px; margin: 0px; padding: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; line-height: 20px'
                                                              _msthash='36583560' _msttexthash='1484041'>
                                                              <a href='{3}/privacy-policy'
                                                                target='_blank' rel='noopener noreferrer' data-auth='NotApplicable'
                                                                class='x_x_Unsubscribe--unsubscribeLink'
                                                                style='color: rgb(33, 224, 157); text-decoration: none'
                                                                data-linkindex='1'>Política de Privacidade</a>
                                                            </p>
                                                          </div>
                                                        </td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' style='padding: 0px 0px 10px 0px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                  <table class='x_x_module' role='module' border='0' cellpadding='0' cellspacing='0'
                                                    width='100%' style='table-layout: fixed'>
                                                    <tbody>
                                                      <tr>
                                                        <td role='module-content' bgcolor='#201E1E' style='padding: 0px 0px 20px'></td>
                                                      </tr>
                                                    </tbody>
                                                  </table>
                                                </td>
                                              </tr>
                                            </tbody>
                                          </table>
                                        </td>
                                      </tr>
                                    </tbody>
                                  </table>
                                </td>
                              </tr>
                            </tbody>
                          </table>
                        </td>
                      </tr>
                    </tbody>
                  </table>
                </body> 
                </html> 
        ";
        }
    }
}