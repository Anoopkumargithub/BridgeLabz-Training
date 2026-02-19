using System;

namespace TechVille.Domain.Entities
{
    /// <summary>
    /// Manages in-memory citizen ID storage using arrays.
    /// </summary>
    public class CitizenDatabase
    {
        private int[] _citizenIds;
        private int _count;

        // 5 zones, each with 4 sectors
        private int[,] _zoneSectorMatrix;

        public CitizenDatabase(int capacity)
        {
            _citizenIds = new int[capacity];
            _zoneSectorMatrix = new int[5, 4];
            _count = 0;
        }

        /// <summary>
        /// Adds citizen ID to array.
        /// </summary>
        public void AddCitizen(int citizenId, int zone, int sector)
        {
            if (_count >= _citizenIds.Length)
                throw new Exception("Database capacity reached.");

            _citizenIds[_count++] = citizenId;

            // Update 2D zone-sector matrix
            _zoneSectorMatrix[zone, sector]++;
        }

        /// <summary>
        /// Displays all citizen IDs.
        /// </summary>
        public void DisplayCitizens()
        {
            Console.WriteLine("\nCitizen IDs:");
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_citizenIds[i]);
            }
        }

        /// <summary>
        /// Bubble sort implementation.
        /// </summary>
        public void SortCitizenIds()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count - i - 1; j++)
                {
                    if (_citizenIds[j] > _citizenIds[j + 1])
                    {
                        int temp = _citizenIds[j];
                        _citizenIds[j] = _citizenIds[j + 1];
                        _citizenIds[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Linear search.
        /// </summary>
        public bool LinearSearch(int target)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_citizenIds[i] == target)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Binary search (requires sorted array).
        /// </summary>
        public bool BinarySearch(int target)
        {
            int left = 0;
            int right = _count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (_citizenIds[mid] == target)
                    return true;

                if (_citizenIds[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        /// <summary>
        /// Displays zone-sector citizen distribution.
        /// </summary>
        public void DisplayZoneMatrix()
        {
            Console.WriteLine("\nZone-Sector Distribution:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Zone {i}: ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(_zoneSectorMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
