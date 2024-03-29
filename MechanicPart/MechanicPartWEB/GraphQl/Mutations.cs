﻿using HotChocolate.Subscriptions;
using MechanicPartWEB.GraphQl.Inputs.Job;
using MechanicPartWEB.GraphQl.Inputs.MechanicTask;
using MechanicPartWEB.GraphQl.Payloads.Jobs;
using MechanicPartWEB.GraphQl.Payloads.MechanicTasks;
using MechanicPartDAL;
using MechanicPartDAL.Entitys;
using MechanicPartWEB.Extensions;

namespace MechanicPartWEB.GraphQl
{
    public class Mutations
    {
        [UseApplicationDbContext]
        public async Task<AddMechanicTaskPayload> AddMechanicTask(
            AddMechanicTaskIntut intut,
            [ScopedService] TaskManagerDbContext context)
        {
            var task = new MechanicsTasks
            {
                MechanicId = intut.MechanicId,
                JobId = intut.JobId,
                Status = intut.Status,
                Task = intut.Task,
            };
            context.MechanicsTasks.Add(task);
            await context.SaveChangesAsync();

            return new AddMechanicTaskPayload(task);

        }




        [UseApplicationDbContext]
        public async Task<ChangeMechanicsTaskPayload> ChangeTask(
        ChangeTaskInput intut,
        [ScopedService] TaskManagerDbContext context)
        {


            var task = context.MechanicsTasks.Find(intut.id);
            if (task == null)
            {
                throw new Exception();
            }

            task.MechanicId = intut.MechanicId;
            task.JobId = intut.JobId;
            task.Status = intut.Status;
            task.Task = intut.Task;


            await context.SaveChangesAsync();

            return new ChangeMechanicsTaskPayload(task);

        }
        [UseApplicationDbContext]
        public async Task<ChangeMechanicsTaskPayload> ChangeTaskStatus(
ChangeTaskStatusInput intut,
[ScopedService] TaskManagerDbContext context,
                [Service] ITopicEventSender eventSender)
        {


            var task = context.MechanicsTasks.Find(intut.id);
            if (task == null)
            {
                throw new Exception();
            }


            task.Status = intut.status;


            await context.SaveChangesAsync();
            await eventSender.SendAsync(
       nameof(Subscriptions.OnTaskStatusUpdateAsync),
       task.Id);
            return new ChangeMechanicsTaskPayload(task);

        }

        [UseApplicationDbContext]
        public async Task<ChangeJobStatusPayload> ChangeJobStatus(
                ChangeJobStatusInput input,
                [ScopedService] TaskManagerDbContext context,
                [Service] ITopicEventSender eventSender)
        {
            var job = context.Jobs.Find(input.id);
            if (job == null)
            {
                throw new Exception();
            }

            job.Status = input.status;

            await context.SaveChangesAsync();
            await eventSender.SendAsync(
        nameof(Subscriptions.OnJobStatusUpdateAsync),
        job.Id);
            return new ChangeJobStatusPayload(job);

        }










    }
}
