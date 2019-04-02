Public Sub ForwardToDesk()
 Dim Explorer As Outlook.Explorer
 Dim CurrentItem As Object
 Dim Sender As Outlook.AddressEntry
 Dim selEmail As Outlook.MailItem
 Dim NewMail As MailItem
 
 Set Explorer = Application.ActiveExplorer
 
 ' Check whether any item is selected in the current folder.
 If Explorer.Selection.Count Then
 
 ' Get the first selected item.
 Set CurrentItem = Explorer.Selection(1)
 
 ' Check for the type of the selected item as only the
 ' MailItem object has the Sender property.
 If CurrentItem.Class = olMail Then
 Set Sender = CurrentItem.Sender
 
 ' There is no sender if the item has not been sent yet.
 If Sender Is Nothing Then
 MsgBox "There's no sender for the current email", vbInformation
 Exit Sub
 End If

 Set NewMail = CurrentItem.Forward
 
 'You can change the concrete info as per your needs
 With NewMail
         .To = "sav@action-telecom.fr"
         .BodyFormat = olFormatHTML
         .Body = "#original_sender {" & CurrentItem.SenderEmailAddress & "}" & vbCrLf & vbCrLf & CurrentItem.Body
         .Display
 End With
 
Set selEmail = Nothing
 
 End If
 End If
End Sub