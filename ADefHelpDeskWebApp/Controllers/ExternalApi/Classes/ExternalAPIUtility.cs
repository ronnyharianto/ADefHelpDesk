//
// ADefHelpDesk.com
// Copyright (c) 2024
// by Michael Washington
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
//
//
using AdefHelpDeskBase.Models;

namespace ADefHelpDeskWebApp.Controllers.ExternalApi.Classes
{
	public static class ExternalAPIUtility
    {
        #region public static DTOTask MapAPITaskToTask(DTOAPITask objTask, DTOAPITaskDetail objTaskDetail)
        public static DTOTask MapAPITaskToTask(DTOAPITask objTask, DTOAPITaskDetail objTaskDetail)
        {
			DTOTask paramTask = new()
			{
				assignedRoleId = objTask.assignedRoleId ?? -1,
				assignedRoleName = objTask.assignedRoleName ?? "",
				createdDate = objTask.createdDate ?? "",
				description = objTask.description ?? "",
				dueDate = objTask.dueDate ?? "",
				estimatedCompletion = objTask.estimatedCompletion ?? "",
				estimatedHours = objTask.estimatedHours,
				estimatedStart = objTask.estimatedStart ?? "",
				portalId = objTask.portalId ?? -1,
				priority = objTask.priority ?? "",
				requesterEmail = objTask.requesterEmail ?? "",
				requesterName = objTask.requesterName ?? "",
				requesterPhone = objTask.requesterPhone ?? "",
				requesterUserId = objTask.requesterUserId ?? -1,
				selectedTreeNodes = objTask.selectedTreeNodes,
				sendEmails = objTask.sendEmails ?? true,
				status = objTask.status ?? "",
				taskId = objTask.taskId ?? -1,
				ticketPassword = objTask.ticketPassword ?? ""
			};

			if (objTaskDetail != null)
            {
				DTOTaskDetail paramDTOTaskDetail = new()
				{
					colDTOAttachment = [],
					contentType = objTaskDetail.contentType ?? "",
					description = objTaskDetail.taskDetailDescription ?? "",
					detailId = objTaskDetail.detailId ?? -1,
					detailType = objTaskDetail.detailType ?? "",
					emailDescription = objTaskDetail.emailDescription ?? "",
					insertDate = objTaskDetail.insertDate ?? "",
					sendEmails = objTaskDetail.sendTaskDetailEmails ?? false,
					startTime = objTaskDetail.startTime ?? "",
					stopTime = objTaskDetail.stopTime ?? "",
					userId = objTaskDetail.userId ?? -1,
					userName = objTaskDetail.userName ?? ""
				};

				paramTask.colDTOTaskDetail = [paramDTOTaskDetail];
            }

            return paramTask;
        } 
        #endregion
    }
}
