using LaCucina.DataLink;
using LaCucina.Models;
using LaCucina.UI;
using System;
using System.Collections.Generic;
using System.Data;

namespace LaCucina.Services
{
    public class KdsService
    {
        private readonly KdsRepository _repo;

        public KdsService() : this(new KdsRepository()) { }

        public KdsService(KdsRepository repo)
        {
            _repo = repo;
        }

        public List<BatchCardDto> GetActiveBatches()
        {
            DataTable dt = _repo.GetActiveBatchesRaw();
            var batches = new Dictionary<int, BatchCardDto>();
            var items = new Dictionary<int, BatchItemDto>();

            foreach (DataRow row in dt.Rows)
            {
                int batchId = Convert.ToInt32(row["batch_id"]);
                int orderItemId = Convert.ToInt32(row["order_item_id"]);

                if (!batches.ContainsKey(batchId))
                {
                    batches[batchId] = new BatchCardDto
                    {
                        BatchId = batchId,
                        OrderId = Convert.ToInt32(row["order_id"]),
                        TableNumber = row["table_number"].ToString(),
                        SpaceName = row["space_name"].ToString(),
                        SentAt = Convert.ToDateTime(row["sent_at"]),
                        BatchStatus = Convert.ToInt32(row["batch_status"])
                    };
                }

                if (!items.ContainsKey(orderItemId))
                {
                    var item = new BatchItemDto
                    {
                        OrderItemId = orderItemId,
                        MenuItemName = row["menu_item_name"].ToString(),
                        Quantity = Convert.ToInt32(row["quantity"]),
                        ItemStatus = Convert.ToInt32(row["item_status"]),
                        NoteText = row["note_text"] == DBNull.Value
                                       ? null
                                       : row["note_text"].ToString()
                    };
                    items[orderItemId] = item;
                    batches[batchId].Items.Add(item);
                }

                if (row["ingredient_name"] != DBNull.Value)
                    items[orderItemId].RemovedIngredients.Add("No " + row["ingredient_name"].ToString());
            }

            return new List<BatchCardDto>(batches.Values);
        }

        public List<KitchenLoadItemDto> GetKitchenLoad()
        {
            DataTable dt = _repo.GetKitchenLoadRaw();
            var result = new List<KitchenLoadItemDto>();

            foreach (DataRow row in dt.Rows)
            {
                result.Add(new KitchenLoadItemDto
                {
                    MenuItemId = Convert.ToInt32(row["menu_item_id"]),
                    MenuItemName = row["menu_item_name"].ToString(),
                    TotalQuantity = Convert.ToInt32(row["total_quantity"])
                });
            }

            return result;
        }

        public int GetTotalItemsInQueue() => _repo.GetTotalItemsInQueue();

        public void MarkItemDone(int orderItemId) => _repo.MarkItemDone(orderItemId);

        public void MarkBatchReady(int batchId) => _repo.MarkBatchReady(batchId);

        public int CountPendingItems(int batchId) => _repo.CountPendingItems(batchId);

        public void MarkAllItemsDone(int batchId) => _repo.MarkAllItemsDone(batchId);

        public List<List<BatchItemDto>> SplitBatchIntoChunks(BatchCardDto batch, int maxHeight)
        {
            var chunks = new List<List<BatchItemDto>>();
            var tempCard = new UCBatchCard();
            int index = 0;

            while (index < batch.Items.Count)
            {
                var chunk = new List<BatchItemDto>();

                for (int i = index; i < batch.Items.Count; i++)
                {
                    chunk.Add(batch.Items[i]);
                    tempCard.pnlBatchItems.Controls.Clear();
                    foreach (var item in chunk)
                    {
                        var uc = new UCItemInBatch();
                        uc.LoadItem(item);
                        tempCard.pnlBatchItems.Controls.Add(uc);
                    }
                    if (tempCard.pnlBatchItems.Height > maxHeight)
                    {
                        chunk.RemoveAt(chunk.Count - 1);
                        break;
                    }
                }

                chunks.Add(chunk);
                index += chunk.Count;
            }

            tempCard.Dispose();
            return chunks;
        }
    }
}