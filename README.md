# AliBabaCloudSMSEnumTest
Test with AliBaba Enums for Json Convertion.

## Short Description
This project is a small test regarding Json convertion. The goal behind this test is to get a mapping working between Ali Cloud and Consumers (so if AliCloud returns a JSON body containing "TemplateType" with an integer 0, the consumer should receive something like "Verification" instead of 0). The mapping affects two Fields of the Json Fields (which are located in the './EnumTestJsonConvert/Samples' folder) and is implemented via enums. The affected Fields are
### TemplateType
Here the documentation offers 4 types:
- 0: represents the verification code.
- 1: for sms notifications.
- 2: indicates promotional text messages.
- 3: international/hong kong, macao and taiwan news.
This is implemented in './EnumTestJsonConvert/MessageFormats/AliCloudTemplateType.cs' inheriting from the file 'AliCloudTemplateType.cs' in the same folder.
### TemplateStatus
Here the documentation only offers 3 values:
- 0: under review.
- 1: audit approved.
- 2: Audit failed, please check the reason for the audit failure in return parameter Reason.
This is implemented in './EnumTestJsonConvert/MessageFormats/AliCloudTemplateState.cs' which is also inheriting from the file 'AliCloudTemplateType.cs' in the same folder.
